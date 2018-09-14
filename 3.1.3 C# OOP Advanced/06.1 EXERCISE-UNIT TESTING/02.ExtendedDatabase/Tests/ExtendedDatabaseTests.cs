using ExtendedDatabase.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace ExtendedDatabase.Tests
{
    [TestFixture]
    public class ExtendedDatabaseTests
    {
        private const int NegativeId = int.MinValue;
        private const int Id = 1;
        private const string Username = "Username";

        private Database database;

        [SetUp]
        public void Init()
        {
            this.database = new Database(new List<Person>());
        }

        [Test]
        public void AddMethodShouldAddPassedObject()
        {
            var firstIndex = this.database.Index;
            this.database.Add(new Person(Id, Username));
            var secondIndex = this.database.Index;

            Assert.AreEqual(firstIndex, secondIndex - 1);
        }

        [Test]
        public void AddPersonWithSameUsernameShoudThrowExeption()
        {
            this.database.Add(new Person(Id, Username));

            Assert.Throws<InvalidOperationException>(() => this.database.Add(new Person(Id + Id, Username)));
        }

        [Test]
        public void AddPersonWithSameIdShoudThrowExeption()
        {
            this.database.Add(new Person(Id, Username));

            Assert.Throws<InvalidOperationException>(() => this.database.Add(new Person(Id, Username + Username)));
        }

        [Test]
        public void RemoveElementShoudRemoveOnlyTheLastElement()
        {
            this.database.Add(new Person(Id, Username));
            var lastIndex = this.database.Index;
            this.database.Remove();
            var currentIndex = this.database.Index;

            Assert.AreEqual(lastIndex, currentIndex + 1);
        }

        [Test]
        public void RemoveElementShouldThrowExceptionIfTheDatabaseIsEmpty()
        {
            Assert.Throws<InvalidOperationException>(() => this.database.Remove());
        }

        [Test]
        public void FindUserByIdThrowsExceptionIfUserDoesNotExistByGivenId()
        {
            this.database.Add(new Person(Id, Username));

            Assert.Throws<InvalidOperationException>(() => this.database.FindById(Id + Id));
        }

        [Test]
        public void FindUserByIdThrowsExceptionIfPassedIdIsNegativeNumber()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => this.database.FindById(NegativeId));
        }

        [Test]
        public void FindUserByUsernameThrowsExceptionIfNoUserIsPresentByPassedUsername()
        {
            this.database.Add(new Person(Id, Username));

            Assert.Throws<InvalidOperationException>(() => this.database.FindByUsername(Username + Username));
        }

        [Test]
        public void FindUserByUsernameThrowsExceptionIfPassedUsernameIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => this.database.FindByUsername(null));
        }

        [Test]
        public void FetchMethodShouldReturnListOfPeople()
        {
            Assert.That(this.database.Fetch() is List<Person>);
        }

        [Test]
        public void FindByIdMethodShouldReturnPerson()
        {
            this.database.Add(new Person(Id, Username));

            Assert.That(this.database.FindById(Id) is Person);
        }

        [Test]
        public void FindByUsernameMethodShouldReturnPerson()
        {
            this.database.Add(new Person(Id, Username));

            Assert.That(this.database.FindByUsername(Username) is Person);
        }
    }
}
