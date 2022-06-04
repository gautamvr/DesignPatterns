using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    internal class ImageMemento : IMemento
    {
        private string _imagePixelData;

        private int _imageSliceNums;

        public ImageMemento(string imagePixelData,int sliceNums)
        {
            _imagePixelData = imagePixelData;
            _imageSliceNums = sliceNums;
        }

        public string GetImageData()
        {
            return _imagePixelData;
        }

        public int GetSliceNums()
        {
            return _imageSliceNums;
        }
    }
}
