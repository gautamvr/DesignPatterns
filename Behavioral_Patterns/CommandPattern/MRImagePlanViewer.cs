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
            if (_currentCommand != null)
            {
                Console.WriteLine($"Perfoming execute of the command {_currentCommand.GetType().Name}");
                _currentCommand.Execute();
                _commandStack.Push(_currentCommand);
            }
        }

        public void ClickUndo()
        {
            var lastCommmand = _commandStack.Pop();
            Console.WriteLine($"Perfoming UNDO of the command {lastCommmand?.GetType().Name}");
            lastCommmand?.Undo();

        }
    }
}
