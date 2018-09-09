using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    interface ILogger
    {
        void LogMessage(string source, string text, LogMessageSeverity severity);

        void LogException(string source, Exception exception, bool isCritical);
    }
}
