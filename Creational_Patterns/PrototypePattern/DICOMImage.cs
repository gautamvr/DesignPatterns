using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    internal abstract class DICOMImage :ICloneable
    {
        public string ImageData { get; set; }   
        public string MetaData { get; set; }

        public string ImageType { get; protected set; }

        public abstract void CreateImage();

        public object Clone()
        {
            Object clone = base.MemberwiseClone();
            return clone;
        }
    }
}
