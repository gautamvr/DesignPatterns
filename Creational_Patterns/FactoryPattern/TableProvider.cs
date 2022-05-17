using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal abstract class TableProvider
    {
        public abstract IDbTable CreateTable(int rows, int columns);

    }
}
