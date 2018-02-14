public class EarthBender : Bender
{
    private float groundSaturation;

    public EarthBender(string name, int power, float groundSaturation) : base(name, power)
    {
        this.GroundSaturation = groundSaturation;
    }

    public float GroundSaturation
    {
        get { return this.groundSaturation; }
        private set { this.groundSaturation = value; }
    }

    public override double GetPower()
    {
        return this.Power * this.GroundSaturation;
    }

    public override string ToString() => $"{base.ToString()}, Ground Saturation: {this.GroundSaturation:f2}";
}
