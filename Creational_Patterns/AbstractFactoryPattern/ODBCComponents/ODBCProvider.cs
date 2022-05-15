namespace AbstractFactoryPatternExample;

public class ODBCProvider:IDbProvider
{
    public IConnection CreateConnection()
    {
        return new ODBCConnection();
    }

    public ICommand CreateCommand()
    {
        return new ODBCCommand();
    }

    public ITransaction CreateTransaction()
    {
        return new ODBCTransaction();
    }
}