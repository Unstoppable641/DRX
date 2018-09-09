using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;

namespace Logger
{
    public class Logger : ILogger
    {
        private static ILog log = LogManager.GetLogger("LOGGER");

        public static ILog Log => log;

        public static void InitLogger()
        {
            XmlConfigurator.Configure();
        }

        public void LogException(string source, Exception exception, bool isCritical)
        {
            throw new NotImplementedException();
        }

        public void LogMessage(string source, string text, LogMessageSeverity severity)
        {
            throw new NotImplementedException();
        }
    }
}
