using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class TextAnnotator:MRImageAnnotator
    {
        public TextAnnotator(IScanImage image):base(image)
        {

        }
        public override void RenderImage()
        {
            AddText();
            base.RenderImage();
        }

        public void AddText()
        {
            Console.WriteLine("Adding text to the image here");

        }
    }
}
