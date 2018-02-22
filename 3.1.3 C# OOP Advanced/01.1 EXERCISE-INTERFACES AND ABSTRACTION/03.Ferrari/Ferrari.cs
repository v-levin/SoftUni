namespace Ferrari
{
    public class Ferrari : IDrivable
    {
        private string driverName;
        private string model;

        public Ferrari(string driverName)
        {
            this.DriverName = driverName;
            this.Model = "488-Spider";
        }

        public string DriverName
        {
            get { return this.driverName; }
            private set { this.driverName = value; }
        }

        public string Model
        {
            get { return this.model; }
            private set { this.model = value; }
        }

        public string Accelerate()
        {
            return "Zadu6avam sA!";
        }

        public string Brake()
        {
            return "Brakes!";
        }
    }
}
