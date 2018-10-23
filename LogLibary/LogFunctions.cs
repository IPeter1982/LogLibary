using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLibary
{
    public partial class Log : ILogFunctions
    {
        public int Debug(string message, int? messageID, Exception exception, string info)
        {
            return LogFunction(logMessageType.Debug, message, messageID, exception, info);
        }

        public int Error(string message, int? messageID, Exception exception, string info)
        {
            return LogFunction(logMessageType.Error, message, messageID, exception, info);
        }

        public int Info(string message, int? messageID, Exception exception, string info)
        {
            return LogFunction(logMessageType.Info, message, messageID, exception, info);
        }

        public int Warning(string message, int? messageID, Exception exception, string info)
        {
            return LogFunction(logMessageType.Warning, message, messageID, exception, info);
        }

        private int LogFunction(logMessageType messageType, string message, int? messageID, Exception exception, string info)
        {
            if (LogToTextFile)
            {

            }
            if (LogToDatabase)
            {

            }
            return 1;
        }

       
    }
}
