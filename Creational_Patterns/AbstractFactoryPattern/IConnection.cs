namespace AbstractFactoryPatternExample;

public interface IConnection
{
    void Interact(ITransaction transaction);
}