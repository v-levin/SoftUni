using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Race
{
    private int length;
    private string route;
    private int prizePool;
    private Dictionary<int, Car> participants;
    private List<Car> winners;

    public Race(int length, string route, int prizePool)
    {
        this.Length = length;
        this.Route = route;
        this.PrizePool = prizePool;
        this.Participants = new Dictionary<int, Car>();
        this.Winners = new List<Car>();
    }

    public int Length
    {
        get { return this.length; }
        private set { this.length = value; }
    }

    public string Route
    {
        get { return this.route; }
        private set { this.route = value; }
    }

    public int PrizePool
    {
        get { return this.prizePool; }
        private set { this.prizePool = value; }
    }

    public Dictionary<int, Car> Participants
    {
        get { return this.participants; }
        private set { this.participants = value; }
    }

    public List<Car> Winners
    {
        get { return this.winners; }
        private set { this.winners = value; }
    }

    public abstract int GetPerformance(int id);

    public virtual void AddParticipant(int carId, Car car)
    {
        this.Participants.Add(carId, car);
    }

    public virtual Dictionary<int, Car> GetWinners()
    {
        var winners = this.Participants.OrderByDescending(n => GetPerformance(n.Key)).Take(3).ToDictionary(n => n.Key, m => m.Value);

        return winners;
    }

    public virtual List<int> GetPrizes()
    {
        var result = new List<int>();
        result.Add((this.PrizePool * Constants.FIRST_PLACE_PRIZE_PERCENTAGE) / Constants.MAXIMUM_PERCENTAGE);
        result.Add((this.PrizePool * Constants.SECOND_PLACE_PRIZE_PERCENTAGE) / Constants.MAXIMUM_PERCENTAGE);
        result.Add((this.PrizePool * Constants.THIRD_PLACE_PRIZE_PERCENTAGE) / Constants.MAXIMUM_PERCENTAGE);

        return result;
    }

    public virtual string StartRace()
    {
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
