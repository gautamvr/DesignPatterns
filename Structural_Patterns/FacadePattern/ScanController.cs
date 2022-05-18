using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    //This is the Facade class. This is the one exposed to client
    internal class ScanController
    {
        private ImageAnnotator _imageAnnotator;
        private ImageDataStore _imageDataStore;
        private ExamcardManager _examcardManager;
        private ScanTimer _scanTimer;
        private ImageGenerator _imageGenerator;

        //Facade class takes care of creation of the instances of different subcomponents
        public ScanController()
        {
            _imageDataStore= new ImageDataStore();
            _examcardManager = new ExamcardManager();
            _imageGenerator = new ImageGenerator();
            _imageAnnotator = new ImageAnnotator();
            _scanTimer = new ScanTimer();
        }

        //Consolidates all the interaction into one public function which would be used by client
        public void StartScan()
        {
            _scanTimer.StartTimer();
            _imageGenerator.GenerateImages();
            _imageAnnotator.AnnotateImage();
            _examcardManager.SelectExamcard();
        }

        public void StopScan()
        {
            _scanTimer.StopTimer();
            _imageAnnotator.AnnotateImage();
            _imageDataStore.StoreImage();
        }
    }
}
