using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    internal class ScanImageCollection : IImageCollection
    {
        private List<string> _imageCollection;

        public int Count
        {
            get => _imageCollection.Count;
        }

        public ScanImageCollection()
        {
            _imageCollection = new List<string>();
        }

        public List<string> GetItems()
        {
            return _imageCollection;
        }

        public void AddImage(string image)
        {
            _imageCollection.Add(image);
        }

        public void RemoveImage(string image)
        {
            _imageCollection.Remove(image);
        }

        public IIterator CreateIterator()
        {
            return new ImageSliceIterator(this);
        }
    }
}
