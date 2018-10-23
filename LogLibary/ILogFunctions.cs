using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLibary
{
    public interface ILogFunctions
    {        
        int Error(string message, int? messageID, Exception exception, string info);
        int Warning(string message, int? messageID, Exception exception, string info);
        int Info(string message, int? messageID, Exception exception, string info);
        int Debug(string message, int? messageID, Exception exception, string info);
    }
}
