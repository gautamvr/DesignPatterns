using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    internal class ImageSlice
    {
        private string _sliceID;

        private int _numOfSlices;

        private ImageType _imageType;

        public ImageSlice(string sliceID,int numOfSlices, ImageType imageType)
        {
            _sliceID = sliceID;
            _numOfSlices = numOfSlices;
            _imageType = imageType;
        }
        public void AddToViewer()
        {
            _imageType.AddToViewer(_sliceID,_numOfSlices);
        }
    }
}
