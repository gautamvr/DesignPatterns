namespace CommandPattern;

public interface IPlanCommand
{
    void Execute();
    void Undo();
}