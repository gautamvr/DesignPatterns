// See https://aka.ms/new-console-template for more information

using FactoryPattern;

Console.WriteLine("Factory Pattern Example");

TableProvider tableProvider = new DBTableCreator();
IDbTable table = tableProvider.CreateTable(4, 4);
Console.WriteLine($"Table is created of type : {table.GetType().Name}");
