public class WaterBender : Bender
{
    private float waterClarity;
    
    public WaterBender(string name, int power, float waterClarity) : base(name, power)
    {
        this.WaterClarity = waterClarity;
    }
    
    public float WaterClarity
    {
        get { return this.waterClarity; }
        private set { this.waterClarity = value; }
    }

    public override double GetPower()
    {
        return this.Power * this.WaterClarity;
    }

    public override string ToString() => $"{base.ToString()}, Water Clarity: {this.WaterClarity:f2}";
}
