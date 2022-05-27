// See https://aka.ms/new-console-template for more information

using CommandPattern;

Console.WriteLine("Command Pattern Implementation\n");
Console.WriteLine("Client Code\n");


MRImagePlanViewer planViewer = new MRImagePlanViewer();
DICOMImage dicomImage = new DICOMImage(10,"Initial Info");

IPlanCommand _annotateCommand = new AddAnnotationCommand(dicomImage, "Updated Info");
IPlanCommand _sliceCommand = new IncreaseSliceCommand(dicomImage);

//Performing Actions from viewer

planViewer.SelectButton(_annotateCommand);


planViewer.ClickButton();
planViewer.ClickUndo();
planViewer.ClickButton();
planViewer.ClickButton();
planViewer.ClickUndo();

planViewer.SelectButton(_sliceCommand);
planViewer.ClickButton();
planViewer.ClickButton();
planViewer.ClickUndo();
planViewer.ClickButton();
planViewer.ClickButton();
planViewer.ClickButton();
planViewer.ClickUndo();



