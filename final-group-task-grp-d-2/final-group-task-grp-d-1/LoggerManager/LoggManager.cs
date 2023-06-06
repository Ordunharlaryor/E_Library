using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggerManager;
using NLog;

namespace LoggerManager
{
    public class LoggManager : ILoggManager
    {
        private static ILogger _logger = NLog.LogManager.GetCurrentClassLogger();



        public void LogError(string message)
        {
            _logger.Error(message);
        }

        public void LogWarning(string message)
        {
            _logger.Warn(message);
        }

        public void LogInfo(string message)
        {
            _logger.Info(message);
        }

        public void LogDebug(string message)
        {
            _logger.Debug(message);
        }
    }
}
