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
}
