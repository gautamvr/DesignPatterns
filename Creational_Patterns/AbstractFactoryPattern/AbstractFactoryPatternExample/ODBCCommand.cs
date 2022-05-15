namespace AbstractFactoryPatternExample;

public class ODBCCommand:ICommand
{
    public void Execute(IConnection connection)
    {
        throw new NotImplementedException();
    }
}