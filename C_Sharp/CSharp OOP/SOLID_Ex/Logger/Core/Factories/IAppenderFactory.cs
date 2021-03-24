namespace Logger.Core.Factories
{
    using Appenders;
    using Enums;
    using Layouts;

    public interface IAppenderFactory
    {
        IAppender CreateAppender(string type, ILayout layout, ReportLevel report);
    }
}
