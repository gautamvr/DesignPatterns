using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    internal class DXRImage : DICOMImage
    {
        public DXRImage()
        {
            ImageType = "CTImage";
        }

        public override void CreateImage()
        {
            Console.WriteLine("Performing various API calls and creating a DXR Image. Takes 5 seconds...");
            Thread.Sleep(5000);
            ImageData = "DummyDXRImage";
            MetaData = "DummyDXRData";
        }
    }
}
