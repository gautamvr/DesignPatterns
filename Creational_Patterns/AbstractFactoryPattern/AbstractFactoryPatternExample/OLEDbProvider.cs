namespace AbstractFactoryPatternExample;

public class OLEDbProvider:IDbProvider
{
    public IConnection CreateConnection()
    {
        return new OLEDbConnection();
    }

    public ICommand CreateCommand()
    {
        return new OLEDbCommand();
    }

    public ITransaction CreateTransaction()
    {
        return new OLEDbTransaction();
    }
}