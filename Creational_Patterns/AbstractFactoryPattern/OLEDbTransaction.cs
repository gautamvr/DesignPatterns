namespace AbstractFactoryPatternExample;

public class OLEDbTransaction:ITransaction
{
    public void GetCommand(ICommand command)
    {
        Console.WriteLine($"{this.GetType().Name} is interacting with {command.GetType().Name}");
    }
}