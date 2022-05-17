using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    internal class MRImage : DICOMImage
    {
        public MRImage()
        {
            ImageType = "MRImage";
        }

        public override void CreateImage()
        {
            Console.WriteLine("Performing various API calls and creating an MR Image. Takes 5 seconds...");
            Thread.Sleep(5000);
            ImageData = "DummyMRImage";
            MetaData = "DummyMRData";
        }
    }
}
