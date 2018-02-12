using System.Collections.Generic;
using System.Linq;

public class Nation
{
    private List<Bender> benders;
    private List<Monument> monuments;

    public Nation()
    {
        this.benders = new List<Bender>();
        this.monuments = new List<Monument>();
    }

    public double GetTotalPower()
    {
        var monumentsIncreasePercentage = this.monuments.Sum(m => m.GetAffinity());
        var totalBendersPower = this.benders.Sum(b => b.GetPower());
        var totalPowerIncrease = totalBendersPower / 100 * monumentsIncreasePercentage;

        return totalBendersPower + totalPowerIncrease;
    }
}
