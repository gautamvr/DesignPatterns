namespace AbstractFactoryPatternExample;

public class ODBCCommand:ICommand
{
    public void Execute(IConnection connection)
    {
        Console.WriteLine($"{this.GetType().Name} is interacting with {connection.GetType().Name}");
    }
}