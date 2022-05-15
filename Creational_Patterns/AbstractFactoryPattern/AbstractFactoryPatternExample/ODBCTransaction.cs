namespace AbstractFactoryPatternExample;

public class ODBCTransaction:ITransaction
{
    public void GetCommand(ICommand command)
    {
        throw new NotImplementedException();
    }
}