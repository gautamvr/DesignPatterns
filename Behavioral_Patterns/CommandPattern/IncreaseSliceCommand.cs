using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class IncreaseSliceCommand :IPlanCommand
    {
        private DICOMImage _image;

        public IncreaseSliceCommand(DICOMImage image)
        {
            _image = image;

        }
        public void Execute()
        {
            var sliceNum = _image.SliceNumber;
            _image.SetSliceNumber(sliceNum+1);
        }

        public void Undo()
        {
            var currentSliceNum = _image.SliceNumber;
            _image.SetSliceNumber(currentSliceNum-1);
        }
    }
}
