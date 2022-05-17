using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class OracleDBTable : IDbTable
    {
        public int NumOfRows { get; set; }
        public int NumOfCols { get; set; }

        public OracleDBTable(int rows,int cols)
        {
            NumOfRows = rows;
            NumOfCols = cols;
            Console.WriteLine($"Creating a OracleDB table with rows : {NumOfRows} and cols : {NumOfCols}");
        }
    }
}
