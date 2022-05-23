using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    internal class ScalingHandler:ImageAugmentationHandler
    {
        public override void ProcessImage()
        {
            Console.WriteLine("Performing Scaling for the image in the Scaling Handler");
            _nextHandler.ProcessImage();
        }
    }
}
