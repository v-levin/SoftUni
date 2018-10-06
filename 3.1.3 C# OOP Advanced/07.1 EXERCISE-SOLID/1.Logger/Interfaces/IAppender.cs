using _Logger.Enums;

namespace _Logger.Interfaces
{
    public interface IAppender
    {
        int Count { get; set; }
        ILayout Layout { get; }
        ReportLevel ReportLevel { get; set; }
        void Append(string timeStamp, string reportLevel, string message);
    }
}
