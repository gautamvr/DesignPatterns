using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    internal class PlanScanComponent:BaseComponent
    {
        private string _planState;

        public PlanScanComponent()
        {
            _planState = "NotPlanned";

        }

        public void StartPlanning()
        {
            _planState = "Planning";
            Console.WriteLine($"Plan state is changed in PlanScan to {_planState}");
            WorkflowController.UpdateScanState(_planState);
        }

        public void StopPlanning()
        {
            _planState = "Planning";
            Console.WriteLine($"Plan state is changed in PlanScan to {_planState}");
            WorkflowController.UpdateScanState(_planState);

        }
    }
}
