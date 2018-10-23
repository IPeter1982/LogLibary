using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLibary
{
    public interface ILogFunctions
    {        
        void Error(string message, int? messageID, Exception exception, string info);
        void Warning(string message, int? messageID, Exception exception, string info);
        void Info(string message, int? messageID, Exception exception, string info);
        void Debug(string message, int? messageID, Exception exception, string info);
    }
}
