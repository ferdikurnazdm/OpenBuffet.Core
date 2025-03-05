using OpenBuffet.Core.Logger.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenBuffet.Core.Logger.Interfaces {
    /// <summary>
    /// this interface is responsible for logging messages
    /// </summary>
    internal interface ILogger {
        bool TryLogging(string message, LogType logType, out Exception exception);
        bool TryCleanAllLogs(out Exception exception);
    }
}
