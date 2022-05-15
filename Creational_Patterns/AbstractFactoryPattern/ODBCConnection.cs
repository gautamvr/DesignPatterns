namespace AbstractFactoryPatternExample;

public class ODBCConnection:IConnection
{
    public void Interact(ITransaction transaction)
    {
        Console.WriteLine($"{this.GetType().Name} is interacting with {transaction.GetType().Name}");
    }
}