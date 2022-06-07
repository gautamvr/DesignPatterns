using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    internal class MRBayScanner : IMRScanner
    {
        public bool IsScanStarted { get; private set; }

        public void StartScan()
        {
            Console.WriteLine("Scan started via actual bay MR scanner");
            IsScanStarted = true;
        }

        public void StopScan()
        {
            Console.WriteLine("Scan started via actual bay MR scanner");
            IsScanStarted = false;
        }

        public void StartReconstruction()
        {
            Console.WriteLine("Reconstruction is started in MR scanner");
        }

        public void StartPostProc()
        {
            Console.WriteLine("Post proc is started in MR Scanner");
        }
    }
}
