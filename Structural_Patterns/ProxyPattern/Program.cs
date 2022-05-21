// See https://aka.ms/new-console-template for more information

using ProxyPattern;

Console.WriteLine("Demo of the Proxy pattern");

Console.WriteLine("Client side ------");

IScanManager scanManager = new ScanManagerProxy(); //Can be initialized using dependency injection
scanManager.GetScanImages();


