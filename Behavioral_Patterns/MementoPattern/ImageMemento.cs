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
        private int _imageSliceNum;

        private ImageParameters _imageParameters;

        public ImageMemento(ImageParameters imageParameters,string imageData,int imageSlices)
        {
            _imageParameters = imageParameters;
            _imagePixelData = imageData;
            _imageSliceNum = imageSlices;

        }

        public void RestoreImage()
        {
            _imageParameters.SetImageData(_imagePixelData,_imageSliceNum);
        }
    }
}
