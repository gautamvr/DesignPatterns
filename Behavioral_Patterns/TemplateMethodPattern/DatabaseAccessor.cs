using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    abstract class DatabaseAccessor
    {
        private string _finalquery;

        //Template method
        public void Run(string query)
        {
            ConnectToDb();
            bool isConnected = ValidateConnection();
            if(isConnected)
            {
                _finalquery = BuildQuery(query);
                ExecuteQuery(_finalquery);
                CloseConnection();
            }
            else
            {
                Console.WriteLine("Database is not connected");
            }
        }

        protected abstract void ConnectToDb();
        protected abstract bool ValidateConnection();
        protected abstract void CloseConnection();
        protected abstract string BuildQuery(string query);
        protected abstract void ExecuteQuery(string query);


    }
}
