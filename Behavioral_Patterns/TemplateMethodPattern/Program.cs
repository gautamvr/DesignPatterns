// See https://aka.ms/new-console-template for more information

using TemplateMethodPattern;

Console.WriteLine("Demo for Template Method Pattern");

DatabaseAccessor dbAccessor = new MSSQLDbAccessor();
string query = "SELECT * from Table";
dbAccessor.Run(query);
