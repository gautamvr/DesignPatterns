using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    internal class ScanWorkflowController:IWorkflowController
    {
        private ExamDashboardComponent _examDashboardComponent;
        private ExamcardsComponent _examcardsComponent;
        private PlanScanComponent _planScanComponent;

        public ScanWorkflowController(ExamDashboardComponent edComponent,ExamcardsComponent examcardsComponent,PlanScanComponent planScanComponent)
        {
            _examDashboardComponent = edComponent;
            _examcardsComponent = examcardsComponent;
            _planScanComponent = planScanComponent;
            _examDashboardComponent.SetController(this);
            _examcardsComponent.SetController(this);
            _planScanComponent.SetController(this);
        }
        public void UpdateScanState(string state)
        {
            Console.WriteLine($"The controller has sent the state to examdashboard");
            _examDashboardComponent.UpdateScanState(state);
        }

        public void StartScan(bool scanStarted)
        {
            if (scanStarted)
            {
                _examcardsComponent.ChangeExamcardState("ScanStarted");
            }
        }

        public void StopScan(bool scanStopped)
        {
            if (scanStopped)
            {
                _planScanComponent.StartPlanning();
            }
        }
    }
}
