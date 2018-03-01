namespace BirthdayCelebrations.Interfaces
{
    public interface ICitizen
    {
        string CitizenName { get; }

        int CitizenAge { get; }

        string Id { get; }

        string Birthday { get; }
    }
}
