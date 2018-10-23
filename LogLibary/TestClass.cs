using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogLibary;

namespace TestNameSapce
{
    /// <summary>
    /// using LogLibary;
    /// Log log = Log.Instance;
    /// log.LogToTextFile = true;
    /// log.LogToDatabase = true;
    /// 
    /// log.Error("Warning", 1, ex, "Some info");
    /// log.Info("info", null, null, null);
    /// 
    /// </summary>

    class TestClass
    {
        public Log log = Log.Instance;
       
        public void test()
        {
            log.LogToTextFile = true;
            log.LogToDatabase = true;

            log.Warning("Warning", null, null, null);
        }
        
    }
}
