using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLibary
{
    /// <summary>
    /// Type of the logging mechanism
    /// Textfile or database
    /// </summary>
    public enum logType
    {
        TextFile = 1,
        Database = 2
    }
    
    /// <summary>
    ///  Type of the log message
    ///  Mandatory/Error/Warn/Info or Debug
    /// </summary>
    public enum logMessageType
    {
        Mandatory = 0,
        Error = 1,
        Warning = 2,
        Info = 3,
        Debug = 4
    }


}


