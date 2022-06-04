// See https://aka.ms/new-console-template for more information

using MementoPattern;

Console.WriteLine("Memento Pattern - Client Side demo");


ImageParameters imageParameters = new ImageParameters("InitialpixedData",4);


imageParameters.PrintCurrentDetails();

ImageHistoryHandler imageHistory = new ImageHistoryHandler(imageParameters);
imageHistory.SaveImage();

imageParameters.PerformImageProcessing("ModifiedpixedData",9);
imageHistory.SaveImage();

imageParameters.PrintCurrentDetails();

imageParameters.PerformImageProcessing("modifyingData",2);

imageParameters.PrintCurrentDetails();

imageHistory.Restore();

imageParameters.PrintCurrentDetails();

imageHistory.Restore();

imageParameters.PrintCurrentDetails();