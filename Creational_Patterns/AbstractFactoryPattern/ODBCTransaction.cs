namespace AbstractFactoryPatternExample;

public class ODBCTransaction:ITransaction
{
    public void GetCommand(ICommand command)
    {
        Console.WriteLine($"{this.GetType().Name} is interacting with {command.GetType().Name}");
    }
}