// See https://aka.ms/new-console-template for more information

using BridgePattern;

Console.WriteLine("Bridge Pattern - Client Side");
Console.WriteLine("----------------------------");


IMRScanner scanSimulator = new MRScannerSimulator();
IMRConsole ingeniaConsole = new IngeniaConsole(scanSimulator);

ingeniaConsole.PerformScan();
ingeniaConsole.PerformPostProcessing();


IMRConsole prodivaConsole = new ProdivaMRConsole(scanSimulator);
prodivaConsole.PerformScan();
prodivaConsole.PerformPostProcessing();

IMRScanner mrBayScanner = new MRBayScanner();
prodivaConsole = new ProdivaMRConsole(mrBayScanner);
prodivaConsole.PerformScan();
prodivaConsole.PerformPostProcessing();
