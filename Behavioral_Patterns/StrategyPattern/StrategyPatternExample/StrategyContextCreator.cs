using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample
{
    internal class StrategyContextCreator
    {
        private Strategy _strategy;

        public StrategyContextCreator(Strategy strategy)
        {
            _strategy = strategy;
        }

        public void PerformOperation()
        {
            _strategy.ExecuteStrategy();
        }
    }
}
