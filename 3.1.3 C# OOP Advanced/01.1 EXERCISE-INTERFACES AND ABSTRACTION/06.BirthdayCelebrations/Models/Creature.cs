using BirthdayCelebrations.Interfaces;

namespace BirthdayCelebrations.Models
{
    public class Creature : ICitizen, IPet
    {
        private string citizenName;
        private int citizenAge;
        private string id;
        private string petName;
        private string birthday;

        public Creature(string citizenName, int citizenAge, string id, string birthday)
        {
            this.CitizenName = citizenName;
            this.CitizenAge = citizenAge;
            this.Id = id;
            this.Birthday = birthday;
        }

        public Creature(string petName, string birthday)
        {
            this.PetName = petName;
            this.Birthday = birthday;
        }

        public string CitizenName
        {
            get { return this.citizenName; }
            private set { this.citizenName = value; }
        }

        public int CitizenAge
        {
            get { return this.citizenAge; }
            private set { this.citizenAge = value; }
        }

        public string Id
        {
            get { return this.id; }
            private set { this.id = value; }
        }

        public string PetName
        {
            get { return this.petName; }
            private set { this.petName = value; }
        }

        public string Birthday
        {
            get { return this.birthday; }
            private set { this.birthday = value; }
        }
    }
}
