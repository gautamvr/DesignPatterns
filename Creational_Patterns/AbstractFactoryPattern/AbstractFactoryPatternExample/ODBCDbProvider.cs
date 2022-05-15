namespace AbstractFactoryPatternExample;

public class ODBCDbProvider:IDbProvider
{
    public IConnection CreateConnection()
    {
        new 
    }

    public ICommand CreateCommand()
    {
        throw new NotImplementedException();
    }

    public ITransaction CreateTransaction()
    {
        throw new NotImplementedException();
    }
}