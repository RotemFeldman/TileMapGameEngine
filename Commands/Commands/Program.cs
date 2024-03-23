class Program
{
    static void Main(string[] args)
    {
        MovementSystem movementSystem = new MovementSystem();
        CommandInvoker commandInvoker = new CommandInvoker();

        commandInvoker.RegisterCommand("/select", new SelectCommand(movementSystem, 0, 0));
        commandInvoker.RegisterCommand("/deselect", new DeselectCommand(movementSystem));
        commandInvoker.RegisterCommand("/move", new MoveTileObjectCommand(movementSystem, 0, 0));
        commandInvoker.RegisterCommand("/help", new HelpCommand(commandInvoker.GetCommands()));

        while (true)
        {
            Console.WriteLine("Enter command\n");
            string commandInput = Console.ReadLine();

            if (commandInput == "/select")
            {
                Console.WriteLine("Chose the postion of the tile object:\n");
                Console.WriteLine("Position X: ");
                string positionsInputX = Console.ReadLine();
                Console.WriteLine("Position Y: ");
                string positionsInputY = Console.ReadLine();
                commandInvoker.ExecuteCommand(commandInput, int.Parse(positionsInputX), int.Parse(positionsInputY));
            }
            else if (commandInput == "/move")
            {
                Console.WriteLine("Chose the postion to move the tile object:\n");
                Console.WriteLine("Position X: ");
                string positionsInputX = Console.ReadLine();
                Console.WriteLine("Position Y: ");
                string positionsInputY = Console.ReadLine();
                commandInvoker.ExecuteCommand(commandInput, int.Parse(positionsInputX), int.Parse(positionsInputY));
            }
            else
                commandInvoker.ExecuteCommand(commandInput);  
        }
    }
}