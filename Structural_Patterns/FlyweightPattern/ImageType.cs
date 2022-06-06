using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    internal class ImageType
    {
        private int[] _sliceColourMatrix;

        private string _imageSize;

        public ImageType(int[] matrix, string imageSize)
        {
            _sliceColourMatrix = matrix;
            _imageSize = imageSize;
        }

        public void AddToViewer(string sliceID,int numOfSlices)
        {
            //Actual operation takes place here
            Console.WriteLine($"Performing the actual adding to viewer of image slice ID : {sliceID}, with num of slices {numOfSlices}");
            Console.WriteLine($"The size of the image is {_imageSize} and slice colour matrix of first val {_sliceColourMatrix[0]} is used here");
        }
    }
}
