using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class ExamDashboard:IScanObserver
    {
        private string _scanProgress;

        public ExamDashboard()
        {
            _scanProgress = "0";
        }
        public void OnScanCompleted(MRScanner mrScanner)
        {
            Console.WriteLine($"Received in {GetType().Name}");
            ChangeScanProgress();
            Console.WriteLine($"The scan progress now changed to {_scanProgress}");
            
        }

        public void ChangeScanProgress()
        {
            _scanProgress = "100";
        }
    }
}
