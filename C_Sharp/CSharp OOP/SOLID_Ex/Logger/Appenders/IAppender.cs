namespace Logger.Appenders
{
    using Enums;

    public interface IAppender
    {
        ReportLevel ReportLevel { get; set; }

        void Append(string date, ReportLevel reportLevel, string message);
    }
}
