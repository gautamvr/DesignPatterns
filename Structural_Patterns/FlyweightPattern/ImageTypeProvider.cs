using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    internal class ImageTypeProvider
    {
        private static IDictionary<string, ImageType> _imageTypes = new Dictionary<string, ImageType>();
        

        public static ImageType GetImageType(string colour, string imageSize)
        {
            string key = colour+ "_" + imageSize;

            if (_imageTypes.ContainsKey(key))
            {
                return _imageTypes[key];
            }

            ImageType newImageType = new ImageType(new int[64], imageSize);
            int[] colourMatrix;
            switch (colour)
            {
                case "Blue":
                    colourMatrix = new int[64];
                    colourMatrix[0] = 5;
                    colourMatrix[1] = 10; // The whole matrix is filled
                    newImageType = new ImageType(colourMatrix, imageSize);
                    break;
                case "Red":
                    colourMatrix = new int[64];
                    colourMatrix[0] = 8;
                    colourMatrix[1] = 20; // The whole matrix is filled for red related values
                    newImageType = new ImageType(colourMatrix, imageSize);
                    break;
                default:
                    break;
            }

            _imageTypes.Add(key, newImageType);
            return _imageTypes[key];
        }
    }
}
