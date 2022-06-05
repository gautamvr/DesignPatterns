using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class MRScanImage:IScanImage
    {
        public void RenderImage()
        {
            //Performing rendering of image
            Console.WriteLine("Performing rending of MR Image");

        }
    }
}
