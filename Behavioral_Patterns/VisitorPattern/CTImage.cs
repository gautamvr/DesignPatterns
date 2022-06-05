using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    internal class CTImage:DIImage
    {
        public string CTImageData;

        public CTImage()
        {
            CTImageData = "CTImageData";
        }
        public void CreateImage()
        {
            Console.WriteLine("Creating CT Image");
        }
        public void Accept(IPlanningTool planningTool)
        {
            planningTool.Plan(this);
        }
    }
}
