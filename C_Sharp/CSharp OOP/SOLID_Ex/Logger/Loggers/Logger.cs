namespace Logger.Loggers
{
    using Appenders;
    using Enums;
    using System.Text;

    public class Logger : ILogger
    {
        private readonly IAppender[] appenders;



        public Logger(params IAppender[] appender)
        {
            this.appenders = appender;
        }




        public void Info(string date, string message)
        {
            this.AppendToAppenders(date, ReportLevel.Info, message);
        }

        public void Warning(string date, string message)
        {
            this.AppendToAppenders(date, ReportLevel.Warning, message);
        }


        public void Error(string date, string message)
        {
            this.AppendToAppenders(date, ReportLevel.Error, message);
        }



        public void Critical(string date, string message)
        {
            this.AppendToAppenders(date, ReportLevel.Critical, message);
        }

        public void Fatal(string date, string message)
        {
            this.AppendToAppenders(date, ReportLevel.Fatal, message);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var appender in this.appenders)
            {
                sb.AppendLine(appender.ToString());
            }

            return sb.ToString().TrimEnd();
        }


        private void AppendToAppenders(string date, ReportLevel reportLevel, string message)
        {
            foreach (var appender in this.appenders)
            {
                appender.Append(date, reportLevel, message);
            }
        }
    }
}
