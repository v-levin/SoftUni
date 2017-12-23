namespace CarSalesman
{
    public class Engine
    {
        private string model;
        private int power;
        private int? displacement;
        private string efficiency;

        public Engine(string model, int power)
        {
            this.model = model;
            this.power = power;
        }

        public string Model
        {
            get { return this.model; }
        }

        public int Displacement
        {
            set { this.displacement = value; }
        }

        public string Efficiency
        {
            set { this.efficiency = value; }
        }

        public override string ToString()
        {
            var engineDisplacement = (this.displacement == null) ? "Displacement: n/a" : $"Displacement: {this.displacement}";
            var engineEfficiency = (this.efficiency == null) ? "Efficiency: n/a" : $"Efficiency: {this.efficiency}";

            return $"    Power: {this.power}" +
                $"\n    {engineDisplacement}" +
                $"\n    {engineEfficiency}";
        }
    }
}
