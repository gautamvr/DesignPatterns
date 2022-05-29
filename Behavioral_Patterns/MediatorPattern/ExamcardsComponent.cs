using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    internal class ExamcardsComponent : BaseComponent
    {
        private string _examcardState;

        public ExamcardsComponent()
        {
            _examcardState = "ReadyToStart";
        }

        public void ChangeExamcardState(string state)
        {
            _examcardState = state;
            Console.WriteLine($"The exam card state is changed to {_examcardState}");
            WorkflowController.UpdateScanState(_examcardState);
            
        }
    }
}
