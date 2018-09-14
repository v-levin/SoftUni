using ExtendedDatabase.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtendedDatabase.Models
{
    public class Database : ICustomCollection
    {
        private const string EmptyCollectionExeptionMessage = "The collection is already empty.";

        private readonly IList<Person> people;
        private int currentIndex;

        public Database(IList<Person> people)
        {
            this.people = people;

            foreach (var person in people)
            {
                this.people.Add(person);
                this.currentIndex++;
            }
        }

        public int Index => this.currentIndex;

        public void Add(Person person)
        {
            if (this.people.Any(p => p.Username.Equals(person.Username)) || this.people.Any(p => p.Id.Equals(person.Id)))
                throw new InvalidOperationException("The person already exists.");

            this.people.Add(person);
            this.currentIndex++;
        }

        public IList<Person> Fetch()
        {
            return this.people.Take(this.currentIndex).ToList();
        }

        public Person FindById(long id)
        {
            if (id < 0)
                throw new ArgumentOutOfRangeException("Id has to be positive number.");

            if (!this.people.Any(p => p.Id.Equals(id)))
                throw new InvalidOperationException("The person does not exists.");

            return this.people.First(p => p.Id.Equals(id));
        }

        public Person FindByUsername(string username)
        {
            if (string.IsNullOrEmpty(username))
                throw new ArgumentNullException("Username is null or emtpy.");

            if (!this.people.Any(p => p.Username.Equals(username)))
                throw new InvalidOperationException("he person does not exists.");

            return this.people.First(p => p.Username.Equals(username));
        }

        public void Remove()
        {
            if (this.currentIndex == 0)
            {
                throw new InvalidOperationException(EmptyCollectionExeptionMessage);
            }

            this.people[this.currentIndex - 1] = null;
            this.currentIndex--;
        }
    }
}
