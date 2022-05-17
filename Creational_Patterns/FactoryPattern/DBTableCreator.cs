using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class DBTableCreator : TableProvider
    {
        public override IDbTable CreateTable(int rows, int columns)
        {
            return new OracleDBTable(rows, columns);
        }
    }
}
