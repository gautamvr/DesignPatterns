using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternExample
{
    internal class DataAccessLayer
    {
        private ICommand _command;
        private IConnection _connection;
        private ITransaction _transaction;

        public DataAccessLayer(IDbProvider dbProvider)
        {
            _connection = dbProvider.CreateConnection();
            _command = dbProvider.CreateCommand();
            _transaction = dbProvider.CreateTransaction();
        }

        public void PerformTask()
        {
            _connection.Interact(_transaction);
            _command.Execute(_connection);
            _transaction.GetCommand(_command);
        }
    }
}
