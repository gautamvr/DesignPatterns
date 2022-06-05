using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class GeometryAnnotator:MRImageAnnotator
    {
        public GeometryAnnotator(IScanImage image):base(image)
        {

        }

        public override void RenderImage()
        {
            AddGeometry();
            base.RenderImage();

        }

        public void AddGeometry()
        {
            Console.WriteLine("Adding geometry to the image");
        }
    }
}
