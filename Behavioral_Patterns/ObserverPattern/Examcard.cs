using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class Examcard :IScanObserver
    {
        private string _examcardIcon;

        public Examcard()
        {
            _examcardIcon = "NotCompletedIcon";
        }
        public void OnScanCompleted(MRScanner mrScanner)
        {
            Console.WriteLine($"Received in {this.GetType().Name}");
            
            ChangeExamcardIcon();
            Console.WriteLine($"The icon ID changed to {_examcardIcon}");
        }

        public void ChangeExamcardIcon()
        {
            _examcardIcon = "CompletedIcon";

        }
    }
}
