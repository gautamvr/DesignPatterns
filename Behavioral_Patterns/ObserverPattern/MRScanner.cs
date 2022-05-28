using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{

    public class MRScanner
    {
        private List<IScanObserver> _invocationList;
        public string ScanState { get; set; }

        public MRScanner()
        {
            _invocationList = new List<IScanObserver>();
            ScanState = "NotStarted";

        }

        public void RegisterSubscriber(IScanObserver observer)
        {
            _invocationList.Add(observer);
        }

        public void DeregisterSubscriber(IScanObserver observer)
        {
            _invocationList.Remove(observer);
        }

        public void NotifyOnScanCompleted()
        {
            foreach (var scanObserver in _invocationList)
            {
                scanObserver.OnScanCompleted(this);
            }
        }

        public void PerformScan()
        {
            Console.WriteLine("Performing Scan, Please wait");
            ScanState = "ScanStarted";
            Thread.Sleep(5000);
            Console.WriteLine("Scan is completed");
            ScanState = "ScanCompleted";
            Console.WriteLine($"The scan state currently is {ScanState}\n");
            NotifyOnScanCompleted();

        }
    }


}
