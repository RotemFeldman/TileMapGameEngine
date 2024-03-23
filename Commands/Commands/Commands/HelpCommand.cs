/// <summary>
/// Command selection for Help
/// </summary>
class HelpCommand : ICommand
{
    private readonly Dictionary<string, ICommand> commands;

    public HelpCommand(Dictionary<string, ICommand> commands)
    {
        this.commands = commands;
    }

    /// <summary>
    /// Executes the Help command from the dictionary in CommandInvoker
    /// </summary>
    public void Execute()
    {
        Console.WriteLine("Avalible Commands:\n");
        foreach (var command in commands)
        {
            Console.WriteLine(command.Key); 
        }
    }
}