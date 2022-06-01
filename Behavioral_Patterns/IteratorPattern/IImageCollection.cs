using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    internal interface IImageCollection
    {
        public int Count { get; }

        public List<string> GetItems();
        public void AddImage(string image);
        public void RemoveImage(string image);
        public IIterator CreateIterator();
    }
}
