using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern_Example
{
    /// <summary>
    /// Bootstrapper Environment for composite scenario
    /// </summary>
    class BootStrapperEnv2
    {
        public void Do()
        {
            ILogger consoleLogger = new ConsoleLogger();
            ILogger dbLogger = new DbLogger();
            ILogger fileLogger = new FileLogger();
            

            BroadcastLogger broadcastLogger = new BroadcastLogger();

            broadcastLogger.AddLogger(consoleLogger);
            broadcastLogger.AddLogger(dbLogger);
            broadcastLogger.AddLogger(fileLogger);

            BiController biController = new BiController(broadcastLogger);
            biController.Interact("Sending messages to Console, DB and File simultaneously");
        }
    }
}
