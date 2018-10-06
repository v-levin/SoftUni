using _Logger.Interfaces;

namespace _Logger.Entities.Layouts
{
    public class SimpleLayout : ILayout
    {
        public string FormatMessage(string timeStamp, string reportLevel, string message)
        {
            return $"{timeStamp} - {reportLevel} - {message}";
        }
    }
}
