// See https://aka.ms/new-console-template for more information

using VisitorPattern;

Console.WriteLine("Visitor Pattern - Client side demo");

DIImage mrImage = new MRImage();
DIImage ctImage = new CTImage();
DIImage dxrImage = new DXRImage();

PlanManager planManager = new PlanManager();

planManager.AddImage(mrImage);
planManager.AddImage(ctImage);
planManager.AddImage(dxrImage);

planManager.PlanAllImages();
