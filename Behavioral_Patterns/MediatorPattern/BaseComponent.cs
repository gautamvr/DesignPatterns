using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    internal class BaseComponent
    {
        protected IWorkflowController WorkflowController;

        public BaseComponent(IWorkflowController workflowController = null)
        {
            WorkflowController = workflowController;
        }

        public void SetController(IWorkflowController controller)
        {
            WorkflowController = controller;
        }
    }
}
