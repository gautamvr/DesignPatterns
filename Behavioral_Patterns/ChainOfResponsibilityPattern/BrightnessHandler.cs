using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    internal class BrightnessHandler:ImageAugmentationHandler
    {
        public override void ProcessImage()
        {
            Console.WriteLine("Performing brightness augmentation in brightness handler");
            _nextHandler?.ProcessImage();
        }
    }
}
