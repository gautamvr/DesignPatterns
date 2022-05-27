using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class AddAnnotationCommand:IPlanCommand
    {
        private string _annotationToAdd;
        private string _lastAnnotation = "";
        private DICOMImage _image;

        public AddAnnotationCommand(DICOMImage image,string annotation)
        {
            _image = image;
            _annotationToAdd = annotation;
        }
        public void Execute()
        {
            _lastAnnotation = _image.Annotation;
            _image.UpdateAnnotation(_annotationToAdd);
        }

        public void Undo()
        {
            if (_lastAnnotation != String.Empty)
            {
                _image.UpdateAnnotation(_lastAnnotation);
            }
            
        }
    }
}
