namespace AbstractFactoryPatternExample;

public interface ICommand
{
    void Execute(IConnection connection);
}