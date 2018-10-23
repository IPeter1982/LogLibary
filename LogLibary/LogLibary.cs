using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLibary
{
    /// <summary>
    ///  LogLibary 
    ///   - using Singleton pattern to each type of log
    ///   - 
    /// </summary>
    public sealed partial class Log
    {
        #region Singleton Log class    
        private static readonly Lazy<Log> lazy = new Lazy<Log>(() => new Log());

        /// <summary>
        /// Instance of the LogLibary
        /// </summary>
        public static Log Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        /// <summary>
        /// Constructor of the LogLibary - private
        /// </summary>
        private Log()
        {

        }
        #endregion  
        
        /// <summary>
        /// Enbales the text file logger
        /// </summary>
        public bool LogToTextFile { get; set; }
        /// <summary>
        /// Enables the database logger
        /// </summary>
        public bool LogToDatabase { get; set; }

    }
}
