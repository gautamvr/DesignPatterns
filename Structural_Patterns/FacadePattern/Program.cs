// See https://aka.ms/new-console-template for more information

using FacadePattern;

Console.WriteLine("Demo for Facade Pattern \n");

//This is the client code

ScanController scanController = new ScanController();
scanController.StartScan();

Console.WriteLine("Scanning...\n");

scanController.StopScan();
