using System;

namespace EqualityLogic
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get => this.name;
            private set { this.name = value; }
        }

        public int Age
        {
            get => this.age;
            private set { this.age = value; }
        }

        public override bool Equals(object obj)
        {
            Person personObj = obj as Person;
            
            return this.Name.Equals(personObj.Name) && this.Age.Equals(personObj.Age);
        }

        public override int GetHashCode()
        {
            int sumOfCharsInName = 0;

            for (int i = 0; i < this.Name.Length; i++)
            {
                sumOfCharsInName += this.Name[i];
            }

            return this.Age + sumOfCharsInName;
        }

        public int CompareTo(Person other)
        {
            int result = this.Name.CompareTo(other.Name);

            if (result == 0)
            {
                result = this.Age.CompareTo(other.Age);
            }

            return result;
        }
    }
}
