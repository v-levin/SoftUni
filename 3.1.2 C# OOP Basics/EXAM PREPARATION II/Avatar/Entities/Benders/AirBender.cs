public class AirBender : Bender
{
    private float aerialIntegrity;

    public AirBender(string name, int power, float aerialIntegrity) : base(name, power)
    {
        this.AerialIntegrity = aerialIntegrity;
    }

    public float AerialIntegrity
    {
        get { return this.aerialIntegrity; }
        private set { this.aerialIntegrity = value; }
    }

    public override double GetPower()
    {
        return this.Power * this.AerialIntegrity;
    }

    public override string ToString() => $"{base.ToString()}, Aerial Integrity: {this.AerialIntegrity:f2}";
}
