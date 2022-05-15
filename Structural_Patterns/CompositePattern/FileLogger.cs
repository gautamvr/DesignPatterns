using System;

namespace CompositeDesignPattern_Example
{
    /// <summary>
    /// Writes the logs to a file
    /// </summary>
    class FileLogger:ILogger
    {
        public void WriteLog(string logString)
        {
            Console.WriteLine($"Writing to a file - logString : {logString}");
            //Place holder to denote the logs are written to a separate file
        }
    }
}
