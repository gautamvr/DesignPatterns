using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    internal class ExamDashboardComponent :BaseComponent
    {
        private string _scanState;

        public ExamDashboardComponent()
        {
            _scanState = "NotStarted";
        }

        public void UpdateScanState(string state)
        {
            _scanState = state;
        }

        public void StartScan()
        {
            Console.WriteLine($"Start scan is triggered in ExamDashboard");
            Console.WriteLine($"Performing some business logic in ExamDashboard");
            WorkflowController.StartScan(true);
        }

        public void StopScan()
        {
            Console.WriteLine($"Start scan is triggered in ExamDashboard");
            Console.WriteLine($"Performing some business logic in ExamDashboard");
            WorkflowController.StopScan(true);
        }
    }
}
