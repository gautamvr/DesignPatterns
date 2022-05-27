using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class DICOMImage
    {
        public DICOMImage(int sliceNumber=10, string annotation="Dummy Image")
        {
            SliceNumber = sliceNumber;
            Annotation = annotation;
        }

        public int SliceNumber { get; private set; }
        public string Annotation { get; private set; }

        public void UpdateAnnotation(string info)
        {
            Annotation = info;
            Console.WriteLine($"Updating annotation to {Annotation}");
        }

        public void SetSliceNumber(int slices)
        {
            SliceNumber = slices;
            Console.WriteLine($"Slice number updated to {SliceNumber}");
        }

    }
}
