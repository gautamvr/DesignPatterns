using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public abstract class BaseMRConsole : IMRConsole
    {
        protected IMRScanner _mrScanner;
        public BaseMRConsole(IMRScanner scanner)
        {
            _mrScanner = scanner;

        }

        public abstract void PerformScan();

        public abstract void PerformPostProcessing();

        public abstract bool CheckScanStatus();
    }
}
