using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    internal class ImagePlanningTool : IPlanningTool
    {
        public void Plan(DIImage image)
        {
            Console.WriteLine("Planning for base image");
        }
        public void Plan(MRImage image)
        {
            Console.WriteLine("Planning for MR image");
        }
        public void Plan(CTImage image)
        {
            Console.WriteLine("Planning for CT image");
        }
        public void Plan(DXRImage image)
        {
            Console.WriteLine("Planning for DXR image");
        }
    }

}
