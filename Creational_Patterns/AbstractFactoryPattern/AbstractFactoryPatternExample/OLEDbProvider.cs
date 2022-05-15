namespace AbstractFactoryPatternExample;

public class OLEDbProvider:IDbProvider
{
    public IConnection CreateConnection()
    {
        throw new NotImplementedException();
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