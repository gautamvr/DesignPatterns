using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    abstract class ImageAugmentationHandler
    {
        protected ImageAugmentationHandler _nextHandler;

        public abstract void ProcessImage();

        public void SetNextHandler(ImageAugmentationHandler handler)
        {
            _nextHandler = handler;
        }
    }
}
