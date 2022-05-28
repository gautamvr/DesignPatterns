// See https://aka.ms/new-console-template for more information

using ObserverPattern_withEvent;

Console.WriteLine("Observer Pattern Demo");

Console.WriteLine("Client side");

var examDashboard = new ExamDashboard();
var examCard = new Examcard();
var mrScanner = MRScanner.Instance;


Console.WriteLine($"The current scan state is {mrScanner.ScanState}");
mrScanner.PerformScan();
