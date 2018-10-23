using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLibary
{
    public partial class Log : ILogFunctions
    {
        public void Debug(string message, int? messageID, Exception exception, string info)
        {
            LogFunction(logMessageType.Debug, message, messageID, exception, info);
        }

        public void Error(string message, int? messageID, Exception exception, string info)
        {
            LogFunction(logMessageType.Error, message, messageID, exception, info);
        }

        public void Info(string message, int? messageID, Exception exception, string info)
        {
            LogFunction(logMessageType.Info, message, messageID, exception, info);
        }

        public void Warning(string message, int? messageID, Exception exception, string info)
        {
            LogFunction(logMessageType.Warning, message, messageID, exception, info);
        }

        private void LogFunction(logMessageType messageType, string message, int? messageID, Exception exception, string info)
        {
            if (LogToTextFile)
            {

            }
            if (LogToDatabase)
            {

            }
        }
    }
}
