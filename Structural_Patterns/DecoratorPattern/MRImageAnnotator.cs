using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class MRImageAnnotator:IScanImage
    {
        IScanImage _scanImage;
        public MRImageAnnotator(IScanImage scanImage)
        {
            _scanImage = scanImage;
        }
        
        public virtual void RenderImage()
        {
            _scanImage.RenderImage();
        }

        void Perform()
        {

        }
    }
}
