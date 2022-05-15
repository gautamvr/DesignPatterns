using System;
using System.Collections.Generic;

namespace CompositeDesignPattern_Example
{
    /// <summary>
    /// Broadcasts the logs to multiple loggers at the same time
    /// </summary>
    class BroadcastLogger:ILogger
    {
        private IList<ILogger> _loggerList = new List<ILogger>();

        public void AddLogger(ILogger logger)
        {
            _loggerList.Add(logger);
        }

        public void RemoveLogger(ILogger logger)
        {
            _loggerList.Remove(logger);
        }

        public void WriteLog(string logString)
        {
            foreach (ILogger logger in _loggerList)
            {
                logger.WriteLog(logString);
            }
        }
    }
}
