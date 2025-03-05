using OpenBuffet.Core.Logger.Interfaces;
using OpenBuffet.Core.Logger.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenBuffet.Core.Logger.Services {
    /// <summary>
    /// this class is responsible for logging messages to the console
    /// </summary>
    internal sealed class ConsoleLogger : ILogger {
        /// <summary>
        /// this method is responsible for cleaning all logs from the console
        /// </summary>
        /// <param name="exception">return null if method runned 
        /// successfully otherwise return exception</param>
        /// <returns>return true if method runned successfully 
        /// otherwise return false</returns>
        public bool TryCleanAllLogs(out Exception exception) {
            bool result = false;
            exception = null;
            try {
                Console.Clear();
                result = true;
            } catch (Exception ex) {
                exception = ex;
                result = false;
            }
            return result;
        }
        /// <summary>
        /// this method is responsible for logging messages to the console
        /// </summary>
        /// <param name="message">log message</param>
        /// <param name="logType">log type</param>
        /// <param name="exception">return null if method runned 
        /// successfully otherwise return exception</param>
        /// <returns>return true if method runned successfully 
        /// otherwise return false</returns>
        public bool TryLogging(string message, LogType logType,out Exception exception) {
            bool result = false;
            exception = null;
            try {
                if (string.IsNullOrWhiteSpace(message)) {
                    exception = new ArgumentNullException($"{nameof(message)} is null or whitespace");
                    return false;
                }
                Console.WriteLine($"{logType} | {DateTime.Now.ToString()} | {message}");
                result = true;
            } catch (Exception ex) {
                exception = ex;
                result = false;
            }
            return result;
        }
    }
}
