using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    internal class SeperatorEvaluator:IDateFormatEvaluator
    {
        public void Evaluate(DateContext context)
        {
            string expression = context.Expression;
            context.Expression = expression.Replace(" ", "-");
        }
    }
}
