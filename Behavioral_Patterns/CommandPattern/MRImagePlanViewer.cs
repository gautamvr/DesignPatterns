using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class MRImagePlanViewer
    {
        private Stack<IPlanCommand> _commandStack;
        private IPlanCommand _currentCommand;

        public MRImagePlanViewer()
        {
            _commandStack = new Stack<IPlanCommand>();
        }

        public void SelectButton(IPlanCommand command)
        {
            _currentCommand = command;
        }

        public void ClickButton()
        {
            Console.WriteLine($"Perfoming execute of the command {_currentCommand?.GetType().Name}");
            _currentCommand?.Execute();
            
        }

        public void ClickUndo()
        {
            Console.WriteLine($"Perfoming UNDO of the command {_currentCommand?.GetType().Name}");
            _currentCommand?.Undo();

        }
    }
}
