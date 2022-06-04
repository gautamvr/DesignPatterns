using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    internal class ImageParameters
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
            return new ImageMemento(_imagePixelData, _imageSliceNums);
        }

        public void RestoreImage(IMemento memento)
        {
            var imageMemento = memento as ImageMemento;
            _imagePixelData = imageMemento.GetImageData();
            _imageSliceNums = imageMemento.GetSliceNums();
        }

        public void PrintCurrentDetails()
        {
            Console.WriteLine($"The current pixelData is {_imagePixelData}");
            Console.WriteLine($"The current slice nums is {_imageSliceNums}\n\n");
        }
    }
}
