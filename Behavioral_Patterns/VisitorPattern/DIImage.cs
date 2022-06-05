using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    internal interface DIImage
    {
        void CreateImage();

        void Accept(IPlanningTool planningTool);
    }
}
