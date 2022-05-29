using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    internal interface IDateFormatEvaluator
    {
        void Evaluate(DateContext context);

    }
}
