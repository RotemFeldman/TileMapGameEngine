public interface IParameterizedCommand : ICommand
{
    void Execute(int x, int y);
}