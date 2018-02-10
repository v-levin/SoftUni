using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CircuitRace : Race
{
    private int laps;

    public CircuitRace(int length, string route, int prizePool, int laps) : base(length, route, prizePool)
    {
        this.Laps = laps;
    }

    public new int Length
    {
        get { return base.Length * this.Laps; }
    }

    public int Laps
    {
        get { return this.laps; }
        private set { this.laps = value; }
    }

    public override int GetPerformance(int id)
    {
        var car = this.Participants[id];

        return (car.Horsepower / car.Acceleration) + (car.Suspension + car.Durability);
    }

    public override Dictionary<int, Car> GetWinners()
    {
        var winners = this.Participants.OrderByDescending(n => GetPerformance(n.Key)).Take(4).ToDictionary(n => n.Key, m => m.Value);

        return winners;
    }

    public override List<int> GetPrizes()
    {
        var result = new List<int>();
        result.Add((this.PrizePool * Constants.CIRCUIT_RACE_FIRST_PLACE_PRIZE_PERCENTAGE) / Constants.MAXIMUM_PERCENTAGE);
        result.Add((this.PrizePool * Constants.CIRCUIT_RACE_SECOND_PLACE_PRIZE_PERCENTAGE) / Constants.MAXIMUM_PERCENTAGE);
        result.Add((this.PrizePool * Constants.CIRCUIT_RACE_THIRD_PLACE_PRIZE_PERCENTAGE) / Constants.MAXIMUM_PERCENTAGE);
        result.Add((this.PrizePool * Constants.CIRCUIT_RACE_FOURTH_PLACE_PRIZE_PERCENTAGE) / Constants.MAXIMUM_PERCENTAGE);

        return result;
    }

    public override string StartRace()
    {
        List<Car> participantCars = new List<Car>();

        participantCars.AddRange(this.Participants.Values);

        for (int lap = 0; lap < this.Laps; lap++)
        {
            foreach (var participantCar in participantCars)
            {
                participantCar.BreakDown(base.Length * base.Length);
            }
        }

        var winners = GetWinners();
        var prizes = GetPrizes();

        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{this.Route} - {this.Length}");

        for (int i = 0; i < winners.Count; i++)
        {
            var car = winners.ElementAt(i);
            sb.AppendLine($"{i + 1}. {car.Value.Brand} {car.Value.Model} {this.GetPerformance(car.Key)}PP - ${prizes[i]}");
        }

        return sb.ToString().Trim();
    }
}
