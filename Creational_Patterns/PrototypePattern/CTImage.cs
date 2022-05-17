using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    internal class CTImage : DICOMImage
    {
        public CTImage()
        {
            ImageType = "CTImage";
        }

        public override void CreateImage()
        {
            Console.WriteLine("Performing various API calls and creating a CT Image. Takes 5 seconds...");
            Thread.Sleep(5000);
            ImageData = "DummyCTImage";
            MetaData = "DummyCTData";
        }
    }
}
