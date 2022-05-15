namespace AbstractFactoryPatternExample;

public class ODBCConnection:IConnection
{
    public void Interact(ITransaction transaction)
    {
        throw new NotImplementedException();
    }
}