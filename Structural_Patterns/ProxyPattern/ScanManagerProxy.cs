using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    //Proxy class(delegated the service call) to monitor the performance of the service call
    internal class ScanManagerProxy : IScanManager
    {
        private IScanManager _scanManagerService;
        
        public void GetScanImages()
        {
            _scanManagerService = new ScanManagerService();  //Lazy initialization
            Console.WriteLine("Starting a timer here in proxy class");
            _scanManagerService.GetScanImages(); //Actual service call
            Console.WriteLine("Stopping the timer after the service call");
        }
    }
}
