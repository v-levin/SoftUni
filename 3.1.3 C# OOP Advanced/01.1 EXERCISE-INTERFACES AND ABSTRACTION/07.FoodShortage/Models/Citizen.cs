using FoodShortage.Interfaces;

namespace FoodShortage.Models
{
    public class Citizen : ICitizen, IBuyer
    {
        private string citizenName;
        private int citizenAge;
        private string citizenId;
        private string citizenBirthday;
        private int food;

        public Citizen(string citizenName, int citizenAge, string citizenId, string citizenBirthday)
        {
            this.CitizenName = citizenName;
            this.CitizenAge = citizenAge;
            this.CitizenId = citizenId;
            this.CitizenBirthday = citizenBirthday;
            this.Food = 0;
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

        public string CitizenId
        {
            get { return this.citizenId; }
            private set { this.citizenId = value; }
        }

        public string CitizenBirthday
        {
            get { return this.citizenBirthday; }
            private set { this.citizenBirthday = value; }
        }

        public int Food
        {
            get { return this.food; }
            private set { this.food = value; }
        }

        public int BuyFood()
        {
            return this.Food += 10;
        }
    }
}
