using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern_Example
{
    /// <summary>
    /// Bootstrapper environment for simple logger scenario
    /// </summary>
    public class BootStrapperEnv1
    {
        public void Do()
        {
            BiController biController = new BiController(new ConsoleLogger());
            biController.Interact("Sending message to console logger");
        }
        
    }
}
