namespace CarSalesman
{
    public class Car
    {
        private string model;
        private Engine engine;
        private int? weight;
        private string color;

        public Car(string model, Engine engine)
        {
            this.model = model;
            this.engine = engine;
        }

        public int Weight
        {
          set { this.weight = value; }
        }

        public string Color
        {
            set { this.color = value; }
        }

        public override string ToString()
        {
            var carWeight = (this.weight == null) ? "Weight: n/a" : $"Weight: {this.weight}";
            var carColor = (this.color == null) ? "Color: n/a" : $"Color: {this.color}";

            return $"{this.model}:" +
                $"\n  {this.engine.Model}:" +
                $"\n{this.engine.ToString()}" +
                $"\n  {carWeight}" +
                $"\n  {carColor}";
        }
    }
}
