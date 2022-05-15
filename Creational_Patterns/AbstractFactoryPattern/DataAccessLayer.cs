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
            _command = dbProvider.CreateCommand();
            _connection = dbProvider.CreateConnection();
            _transaction = dbProvider.CreateTransaction();
        }

        public void PerformTask()
        {
            _command.Execute(_connection);
            _connection.Interact(_transaction);
            _transaction.GetCommand(_command);
        }
    }
}
