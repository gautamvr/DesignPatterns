using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    internal class ImageSliceIterator :IIterator
    {
        private IImageCollection _imageCollection;
        private int _currentSlice;

        public ImageSliceIterator(IImageCollection imageCollection)
        {
            _currentSlice = -1;
            _imageCollection = imageCollection;

        }

        public int TotalSliceNum()
        {
            return _imageCollection.Count;
            ;
        }

        public string NextSlice()
        {
            var outStr = "";
            _currentSlice++;
            if (!IsDone())
            {
                outStr= _imageCollection.GetItems()[_currentSlice];
            }

            return outStr;
        }

        public int CurrentSlice()
        {
            return _currentSlice;
        }

        public bool IsDone()
        {
            if (_currentSlice >= _imageCollection.Count)
            {
                return true;
            }

            return false;
        }
    }
}
