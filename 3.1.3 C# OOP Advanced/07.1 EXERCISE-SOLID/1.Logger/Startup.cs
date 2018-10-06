using _Logger.Entities;
using _Logger.Enums;
using _Logger.Factories;
using _Logger.Interfaces;
using System;
using System.Globalization;

namespace _Logger
{
    public class Startup
    {
        public static void Main()
        {
            var appenderCount = int.Parse(Console.ReadLine());
            var appenders = new IAppender[appenderCount];

            for (int i = 0; i < appenderCount; i++)
            {
                var appenderInfo = Console.ReadLine().Split();
                var currentLayout = LayoutFactory.GetInstance(appenderInfo[1]);
                var currentAppender = AppenderFactory.GetAppender(appenderInfo[0], currentLayout);

                if (appenderInfo.Length > 2)
                {
                    var enumName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(appenderInfo[2].ToLower());
                    currentAppender.ReportLevel = (ReportLevel)Enum.Parse(typeof(ReportLevel), enumName);
                }

                appenders[i] = currentAppender;
            }

            var myLogger = new Logger(appenders);

            string inputMsg;
            while ((inputMsg = Console.ReadLine()) != "END")
            {
                var tokens = inputMsg.Split('|');
                var methodName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tokens[0].ToLower());
                var currentMethod = typeof(Logger).GetMethod(methodName);
                currentMethod.Invoke(myLogger, new object[] { tokens[1], tokens[2] });
            }

            Console.WriteLine(myLogger);
        }
    }
}
