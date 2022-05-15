namespace AbstractFactoryPatternExample;

public interface ITransaction
{
    void GetCommand(ICommand command);
}