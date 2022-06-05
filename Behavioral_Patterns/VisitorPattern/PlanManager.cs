using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    internal class PlanManager
    {
        private IPlanningTool _planningTool;
        private List<DIImage> _images;

        public PlanManager()
        {
            _planningTool = new ImagePlanningTool();
            _images = new List<DIImage>();
        }

        public void AddImage(DIImage image)
        {
            _images.Add(image);
        }

        public void PlanAllImages()
        {
            foreach (var image in _images)
            {
                image.CreateImage();
                image.Accept(_planningTool);

                //The above functionality can still be handled without the use of visitor pattern by casting the parameter as dynamic as below
                //_planningTool.Plan(image as dynamic);
            }
        }
    }
}
