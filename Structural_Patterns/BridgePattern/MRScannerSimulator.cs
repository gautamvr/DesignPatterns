using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    internal class MRScannerSimulator:IMRScanner
    {
        public bool IsScanStarted { get; set; }
        public void StartScan()
        {
            IsScanStarted = true;
            Console.WriteLine("Scan is started from simulator");
        }

        public void StopScan()
        {
            IsScanStarted = false;
            Console.WriteLine("Scan is stopped from simulator");
        }

        public void StartReconstruction()
        {
            Console.WriteLine("Recon is started");
        }

        public void StartPostProc()
        {
            Console.WriteLine("Post processing is started");
        }
    }
}
