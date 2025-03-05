using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenBuffet.Core.Logger.Types {
    /// <summary>
    /// Log type as enum
    /// </summary>
    public enum LogType {
        /// <summary>
        /// success log type
        /// </summary>
        Success = 0,
        /// <summary>
        /// error log type
        /// </summary>
        Error = 1,
        /// <summary>
        /// info log type
        /// </summary>
        Info = 2,
        /// <summary>
        /// warning log type
        /// </summary>
        Warning = 3
    }
}
