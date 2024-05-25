using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LoggerLib
{
    public class Logger : ILogger
    {
        private List<IAppender> appenders = [];
        public Logger(IAppender appender)
        {
            this.appenders.Add(appender);
        }

        public Logger(IAppender appender0, IAppender appender1)
        {
            this.appenders.Add(appender0);
            this.appenders.Add(appender1);

        }

        public Logger(params IAppender[] appenders)
        {
            this.appenders.AddRange(appenders);
        }

        public void Info(string date, string info)
        {
            foreach (var appender in appenders)
            {
                if (appender.ReportLevel > ReportLevel.INFO)
                    return;

                appender.append(date, info, ReportLevel.INFO);
            }
        }

        public void Warn(string date, string warn)
        {
            foreach (var appender in appenders)
            {
                if (appender.ReportLevel > ReportLevel.WARNING)
                    return;

                appender.append(date, warn, ReportLevel.WARNING);
            }
        }

        public void Error(string date, string error)
        {
            foreach (var appender in appenders)
            {
                if (appender.ReportLevel > ReportLevel.ERROR)
                    return;

                appender.append(date, error, ReportLevel.ERROR);
            }
        }

        public void Critical(string date, string error)
        {
            foreach (var appender in appenders)
            {
                if (appender.ReportLevel > ReportLevel.CRITICAL)
                    return;

                appender.append(date, error, ReportLevel.CRITICAL);
            }
        }

        public void Fatal(string date, string error)
        {
            foreach (var appender in appenders)
            {
                if (appender.ReportLevel > ReportLevel.FATAL)
                    return;

                appender.append(date, error, ReportLevel.FATAL);
            }
        }
    }
}
