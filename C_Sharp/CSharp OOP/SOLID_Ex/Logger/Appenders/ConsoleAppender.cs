namespace Logger.Appenders
{
    using Enums;
    using Layouts;
    using System;

    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout)
            : base(layout)
        {
        }

        public override void Append(string date, ReportLevel reportLevel, string message)
        {
            if (this.CanAppend(reportLevel))
            {
                this.MessagesCount += 1;

                string content = string.Format(this.layout.Template, date, reportLevel, message);

                Console.WriteLine(content);
            }

         
        }
    }
}
