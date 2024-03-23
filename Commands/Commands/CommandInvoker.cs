/// <summary>
/// Invoker that adds and executes commands
/// </summary>
public class CommandInvoker
{
    private readonly Dictionary<String, ICommand> _commands = new Dictionary<String, ICommand>();

    /// <summary>
    /// Adds a command to the commands dictionary
    /// </summary>
    /// <param name="commandName"></param>
    /// <param name="command"></param>
    public void RegisterCommand(string commandName, ICommand command)
    {
        _commands.Add(commandName, command);    
    }

    /// <summary>
    /// Executes the command by command name
    /// </summary>
    /// <param name="commandName"></param>
    public void ExecuteCommand(string commandName)
    {
        if(_commands.ContainsKey(commandName))
        {
            _commands[commandName].Execute();
        }
        else
        {
            Console.WriteLine($"The command \"{commandName}\" not recognized. Type /help to see availible commands");
        }
    }

    /// <summary>
    /// Executes the command by command name (with parameters)
    /// </summary>
    /// <param name="commandName"></param>
    public void ExecuteCommand(string commandName, int x = 0, int y = 0)
    {
        if (_commands.ContainsKey(commandName))
        {
            if (_commands[commandName] is IParameterizedCommand parameterizedCommand)
            {
                parameterizedCommand.Execute(x, y);
            }
            else
            {
                Console.WriteLine($"Command '{commandName}' does not accept parameters.");
            }
        }
        else
        {
            Console.WriteLine($"Command \"{commandName}\" not recognized. Type '/help' for available commands.");
        }
    }

    public Dictionary<String, ICommand> GetCommands()
    {
        return _commands;
    }
}