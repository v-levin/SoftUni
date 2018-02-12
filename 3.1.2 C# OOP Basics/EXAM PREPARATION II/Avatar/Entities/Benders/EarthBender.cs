public class EarthBender : Bender
{
    private float groundSaturation;

    public EarthBender(string name, int power) : base(name, power)
    {
        this.GroundSaturation = groundSaturation;
    }

    public float GroundSaturation
    {
        get { return this.groundSaturation; }
        private set { this.groundSaturation = value; }
    }
}
