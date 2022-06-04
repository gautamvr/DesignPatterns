using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    internal class ImageHistoryHandler
    {
        private Stack<IMemento> _imageHistory;

        private IImageParameter _imageParameters;

        public ImageHistoryHandler(IImageParameter imageParameters)
        {
            _imageParameters = imageParameters;
            _imageHistory = new Stack<IMemento>();
        }

        public void SaveImage()
        {
            IMemento imageMemento = _imageParameters.SaveImage();
            
            _imageHistory.Push(imageMemento);
        }

        public void Restore()
        {
            if (_imageHistory.Count > 0)
            {
                var lastImage = _imageHistory.Pop();
                lastImage.RestoreImage();
            }
            
        }
    }
}
