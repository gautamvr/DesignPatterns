using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public interface IIterator
    {
        public int TotalSliceNum();
        public string NextSlice();
        public int CurrentSlice();
        public bool IsDone();




    }
}
