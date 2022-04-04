using System;

namespace CompositeDesignPattern_Example
{
    /// <summary>
    /// Writes the logs to the console
    /// </summary>
    class ConsoleLogger:ILogger
    {
        public void WriteLog(string logString)
        {
            Console.WriteLine($"Writing to the console - logstring : {logString}");
        }
    }
}
