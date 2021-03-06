// See https://aka.ms/new-console-template for more information

using ObserverPattern;

Console.WriteLine("Observer Pattern Demo");

Console.WriteLine("Client side");

var examDashboard = new ExamDashboard();
var examCard = new Examcard();
var mrScanner = new MRScanner();

mrScanner.RegisterSubscriber(examCard);
mrScanner.RegisterSubscriber(examDashboard);


Console.WriteLine($"The current scan state is {mrScanner.ScanState}");
mrScanner.PerformScan();

