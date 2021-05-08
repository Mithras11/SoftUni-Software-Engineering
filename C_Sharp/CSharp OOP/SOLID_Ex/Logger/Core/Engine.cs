namespace Logger.Core
{
    using Enums;
    using Factories;
    using Appenders;
    using Loggers;
    using System;
    using Core.IO;

    public class Engine : IEngine
    {
        private readonly IAppenderFactory appenderFactory;
        private readonly ILayoutFactory layoutFactory;
        private readonly IReader reader;
        private ILogger logger;
       


        public Engine(IAppenderFactory appenderFactory, ILayoutFactory layoutFactory,IReader reader)
        {
            this.appenderFactory = appenderFactory;
            this.layoutFactory = layoutFactory;
            this.reader = reader;
        }

        public void Run()
        {


            int n = int.Parse(this.reader.ReadLine());

            var appenders = this.ReadAppanders(n);
            this.logger = new Logger(appenders);

            while (true)
            {
                string line = this.reader.ReadLine();

                if (line == "END")
                {
                    break;
                }


                var parts = line.Split('|', StringSplitOptions.RemoveEmptyEntries);

                var reportLevel = Enum.Parse<ReportLevel>(parts[0], true);
                var date = parts[1];
                var message = parts[2];

                this.ProcessCommand(reportLevel, date, message);
            }

            Console.WriteLine("Logger info");
            Console.WriteLine(logger);
        }

        private void ProcessCommand(ReportLevel reportLevel, string date, string message)
        {
            switch (reportLevel)
            {
                case ReportLevel.Info:
                    this.logger.Info(date, message);
                    break;

                case ReportLevel.Warning:
                    this.logger.Warning(date, message);
                    break;

                case ReportLevel.Error:
                    this.logger.Error(date, message);
                    break;

                case ReportLevel.Critical:
                    this.logger.Critical(date, message);
                    break;


                case ReportLevel.Fatal:
                    this.logger.Fatal(date, message);
                    break;

            }
        }

        private IAppender[] ReadAppanders(int n)
        {
            var appenders = new IAppender[n];

            for (int i = 0; i < n; i++)
            {
                var appenderParts = this.reader.ReadLine().Split();

                var appenderType = appenderParts[0];
                var layoutType = appenderParts[1];

                var reportLevel = appenderParts.Length == 3
                    ? Enum.Parse<ReportLevel>(appenderParts[2], true)
                    : ReportLevel.Info;

                var layout = this.layoutFactory.CreateLayout(layoutType);

                var appender = this.appenderFactory.CreateAppender(appenderType, layout, reportLevel);
                appenders[i] = appender;
            }

            return appenders;
        }
    }
}
