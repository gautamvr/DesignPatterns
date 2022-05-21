using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    internal class ScanManagerService : IScanManager
    {
        public void GetScanImages()
        {
            Console.WriteLine("Performing Actual business Logic of ScanManagerService");
        }
    }
}
