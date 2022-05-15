using System;

namespace CompositeDesignPattern_Example
{
    /// <summary>
    /// Writes the logs to a DB
    /// </summary>
    class DbLogger:ILogger
    {
        public void WriteLog(string logString)
        {
            Console.WriteLine($"Writing to the DB - logString : {logString}");
            //Place holder to denote the logs writing to a DB
        }
    }
}
