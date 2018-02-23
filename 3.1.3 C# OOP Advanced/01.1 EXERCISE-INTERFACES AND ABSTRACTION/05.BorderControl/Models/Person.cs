using BorderControl.Interfaces;

namespace BorderControl.Models
{
    public class Person : ICitizen, IRobot
    {
        private string citizenName;
        private int citizenAge;
        private string robotModel;
        private string id;

        public Person(string citizenName, int citizenAge, string id)
        {
            this.CitizenName = citizenName;
            this.CitizenAge = citizenAge;
            this.Id = id;
        }

        public Person(string robotModel, string id)
        {
            this.RobotModel = robotModel;
            this.Id = id;
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

        public string RobotModel
        {
            get { return this.robotModel; }
            private set { this.robotModel = value; }
        }

        public string Id
        {
            get { return this.id; }
            private set { this.id = value; }
        }
    }
}
