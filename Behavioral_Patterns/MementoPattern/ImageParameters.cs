using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    internal class ImageParameters : IImageParameter
    {
        private string _imagePixelData;

        private int _imageSliceNums;

        public ImageParameters(string pixelData, int sliceNum)
        {
            _imageSliceNums = sliceNum;
            _imagePixelData = pixelData;
        }

        public void PerformImageProcessing(string pixelData, int sliceNum)
        {
            _imageSliceNums = sliceNum;
            _imagePixelData = pixelData;
        }

        public IMemento SaveImage()
        {
            return new ImageMemento(this,_imagePixelData, _imageSliceNums);
        }

        public void SetImageData(string imageData, int sliceNums)
        {
            _imagePixelData = imageData;
            _imageSliceNums = sliceNums;;
        }

        public void PrintCurrentDetails()
        {
            Console.WriteLine($"The current pixelData is {_imagePixelData}");
            Console.WriteLine($"The current slice nums is {_imageSliceNums}\n\n");
        }
    }
}
