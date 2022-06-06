using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    internal class ImageController
    {
        private List<ImageSlice> imageSlices = new List<ImageSlice>();

        public void AddSlices(string sliceID, string imageColour,string imageSize,int numOfSlices)
        {
            var imageType = ImageTypeProvider.GetImageType(imageColour, imageSize);

            ImageSlice imageSlice = new ImageSlice(sliceID,numOfSlices, imageType);

            imageSlices.Add(imageSlice);
        }

        public void DisplayWholeImage()
        {
            foreach (var imageSlice in imageSlices)
            {
                imageSlice.AddToViewer();
            }
        }
    }
}
