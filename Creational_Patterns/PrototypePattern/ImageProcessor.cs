using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    internal class ImageProcessor
    {
        public ImageProcessor()
        {
            DICOMImageProvider dicomImageProvider = new DICOMImageProvider();
            Console.WriteLine("MR Image prototype is loaded");
            dicomImageProvider.LoadMRImagePrototype();


            for (int i = 0; i < 10; i++)
            {
                DICOMImage mrImage = dicomImageProvider.CreateImage("MRImage");
                mrImage.MetaData = i.ToString();
                ProcessImage(mrImage);
            }

            Console.WriteLine("-----------------------------------------------------");

            dicomImageProvider.LoadCTImagePrototype();

            DICOMImage ctImage = dicomImageProvider.CreateImage("CTImage");
            ctImage.MetaData = "2";
            ProcessImage(ctImage);

            DICOMImage ctImage2 = dicomImageProvider.CreateImage("CTImage");
            ctImage2.MetaData = "3";
            ProcessImage(ctImage2);

        }

        public void ProcessImage(DICOMImage image)
        {
            Console.WriteLine($"Processing image of type {image.ImageType} with metadata {image.MetaData}");
        }
    }
}
