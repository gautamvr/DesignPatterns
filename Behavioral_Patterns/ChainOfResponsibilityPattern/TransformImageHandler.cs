using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    internal class TransformImageHandler:ImageAugmentationHandler
    {
        public override void ProcessImage()
        {
            Console.WriteLine("Performing Transformation of the image in Transform handler");
            _nextHandler.ProcessImage();
        }
    }
}
