using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern_withEvent
{
    internal class ExamDashboard
    {
        private string _scanProgress;

        public ExamDashboard()
        {
            _scanProgress = "0";
            var mrScanner = MRScanner.Instance;
            mrScanner.ScanCompleted += OnScanCompleted;
        }
        public void OnScanCompleted(object sender, EventArgs e)
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
