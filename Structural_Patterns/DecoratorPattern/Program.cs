// See https://aka.ms/new-console-template for more information
using DecoratorPattern;

Console.WriteLine("Decorator Pattern - Client side");

IScanImage scanImage = new MRScanImage();

scanImage = new TextAnnotator(scanImage);
scanImage = new GeometryAnnotator(scanImage);

scanImage.RenderImage();
