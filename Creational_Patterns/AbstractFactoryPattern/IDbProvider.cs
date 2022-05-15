namespace AbstractFactoryPatternExample;

public interface IDbProvider
{
    IConnection CreateConnection();
    ICommand CreateCommand();
    ITransaction CreateTransaction();

}