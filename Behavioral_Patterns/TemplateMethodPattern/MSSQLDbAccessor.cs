using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    internal class MSSQLDbAccessor : DatabaseAccessor
    {
        protected override void ConnectToDb()
        {
            //MS SQL specific connection logic
            Console.WriteLine("Connecting to MS SQL Database");
        }

        protected override bool ValidateConnection()
        {
            //Preforms validation and returns if the connection is established
            Console.WriteLine("Performing validation to check if connection is established");
            return true;
        }

        protected override void CloseConnection()
        {
            Console.WriteLine("Closing the connection of MS SQL Db");
        }

        protected override string BuildQuery(string query)
        {
            Console.WriteLine("Building the query string specific to MS SQL needs");
            return "MSSQLPrefix " + query;
        }

        protected override void ExecuteQuery(string query)
        {
            Console.WriteLine($"Executing the below query in MS Sql Database:\n\t {query}");
        }
    }
}
