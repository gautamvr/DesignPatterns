using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    internal class DXRImage:DIImage
    {
        public string DxrImageData;

        public DXRImage()
        {
            DxrImageData = "DXRImageData";
        }
        public void CreateImage()
        {
            Console.WriteLine("Creating DXR Image");
        }
        public void Accept(IPlanningTool planningTool)
        {
            planningTool.Plan(this);
        }
    }
}
