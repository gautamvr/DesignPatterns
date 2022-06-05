using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    internal class MRImage:DIImage
    {
        public string MRImageData;

        public MRImage()
        {
            MRImageData = "MRImageData";
        }
        public void CreateImage()
        {
            Console.WriteLine("Creating MR Image");
        }

        public void Accept(IPlanningTool planningTool)
        {
            planningTool.Plan(this);
        }
    }
}
