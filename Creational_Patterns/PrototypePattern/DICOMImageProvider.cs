using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    internal class DICOMImageProvider
    {
        private Dictionary<string, DICOMImage> _imageInstanceStore = new Dictionary<string, DICOMImage>();

        private MRImage mrPrototype;
        private CTImage ctPrototype;
        private DXRImage dxrPrototype;

        public void LoadMRImagePrototype()
        {
            DICOMImage mrImage = new MRImage();
            mrImage.CreateImage();
            _imageInstanceStore.Add(mrImage.ImageType, mrImage);
        }

        public void LoadCTImagePrototype()
        {
            DICOMImage ctImage = new CTImage();
            ctImage.CreateImage();
            _imageInstanceStore.Add(ctImage.ImageType, ctImage);
        }

        public void LoadDXRImagePrototype()
        {
            DICOMImage dxrImage = new DXRImage();
            dxrImage.CreateImage();
            _imageInstanceStore.Add(dxrImage.ImageType, dxrImage);
        }

        public DICOMImage CreateImage(string imageType)
        {
            Console.WriteLine($"\nCreating new image of type {imageType}");
            return (_imageInstanceStore[imageType].Clone() as DICOMImage)!;
        }
    }
}
