/// <summary>
/// Interface to excute commands with parameters
/// </summary>
public interface IParameterizedCommand : ICommand
{
    void Execute(int x, int y);
}