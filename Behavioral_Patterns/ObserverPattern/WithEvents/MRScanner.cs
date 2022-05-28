using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern_withEvent
{
    internal class MRScanner
    {
        private static MRScanner _mrScanner;
        private static object _locker = new object();
        public string ScanState { get; set; }

        public event ScanCompletedEventHandler ScanCompleted;

        public static MRScanner Instance
        {
            get
            {
                if (_mrScanner == null)
                {
                    lock (_locker)
                    {
                        if (_mrScanner == null)
                        {
                            _mrScanner = new MRScanner();
                        }
                    }
                }

                return _mrScanner;
            }
        }

        private MRScanner()
        {
            ScanState = "NotStarted";
        }

        public void PerformScan()
        {
            Console.WriteLine("Performing Scan, Please wait");
            ScanState = "ScanStarted";
            Thread.Sleep(5000);
            Console.WriteLine("Scan is completed");
            ScanState = "ScanCompleted";
            Console.WriteLine($"The scan state currently is {ScanState}\n");
            ScanCompleted?.Invoke(this,EventArgs.Empty);
        }


    }
}
