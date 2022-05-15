// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using AbstractFactoryPatternExample;

Console.WriteLine("Tester program started");

IDbProvider dbProvider1 = new ODBCProvider();
DataAccessLayer DAL1 = new DataAccessLayer(dbProvider1);
DAL1.PerformTask();

Console.WriteLine("------------------------------------");

IDbProvider dbProvider2 = new OLEDbProvider();
DataAccessLayer DAL2 = new DataAccessLayer(dbProvider2);
DAL2.PerformTask();
