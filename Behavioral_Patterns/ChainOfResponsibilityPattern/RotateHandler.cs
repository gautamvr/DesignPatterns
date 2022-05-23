using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    internal class RotateHandler :ImageAugmentationHandler
    {
        public override void ProcessImage()
        {
            Console.WriteLine("Performing Rotate of the image in RotateHandler");
            _nextHandler?.ProcessImage();
        }
    }
}
