using System;
using System.Linq;
using System.Text;

public class TimeLimitRace : Race
{
    private int goldTime;

    public TimeLimitRace(int length, string route, int prizePool, int goldTime) : base(length, route, prizePool)
    {
        this.goldTime = goldTime;
    }

    public int GoldTime
    {
        get { return this.goldTime; }
        private set { this.goldTime = value; }
    }

    public override void AddParticipant(int carId, Car car)
    {
        if (this.Participants.Count == 0)
        {
            base.AddParticipant(carId, car);
        }
    }

    public override int GetPerformance(int id)
    {
        var car = this.Participants[id];

        return this.Length * ((car.Horsepower / 100) * car.Acceleration);
    }

    public string GetTimeClassification(int time)
    {
        var result = string.Empty;

        if (time <= this.GoldTime)
        {
            result = "Gold";
        }
        else if (time <= this.GoldTime + Constants.TIME_LIMIT_RACE_SILVER_TIME_SECONDS_OFFSET)
        {
            result = "Silver";
        }
        else if (time > this.GoldTime + Constants.TIME_LIMIT_RACE_SILVER_TIME_SECONDS_OFFSET)
        {
            result = "Bronze";
        }

        return result;
    }

    private int GetPrize(string winnerTimeClassification)
    {
        var result = this.PrizePool;

        if (winnerTimeClassification == "Gold")
        {
            result = (result * Constants.TIME_LIMIT_RACE_FIRST_PLACE_PRIZE_PERCENTAGE) / Constants.MAXIMUM_PERCENTAGE;
        }
        else if (winnerTimeClassification == "Silver")
        {
            result = (result * Constants.TIME_LIMIT_RACE_SECOND_PLACE_PRIZE_PERCENTAGE) / Constants.MAXIMUM_PERCENTAGE;
        }
        else if (winnerTimeClassification == "Bronze")
        {
            result = (result * Constants.TIME_LIMIT_RACE_THIRD_PLACE_PRIZE_PERCENTAGE) / Constants.MAXIMUM_PERCENTAGE;
        }

        return result;
    }

    public override string StartRace()
    {
        var winner = this.Participants.First();
        var winnerTimeClassification = GetTimeClassification(this.GetPerformance(winner.Key));
        var prize = GetPrize(winnerTimeClassification);

        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{this.Route} - {this.Length}");
        sb.AppendLine($"{winner.Value.Brand} {winner.Value.Model} - {this.GetPerformance(winner.Key)} s.");
        sb.Append($"{winnerTimeClassification} Time, ${prize}.");

        return sb.ToString();
    }
}
