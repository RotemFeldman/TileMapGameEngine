/// <summary>
/// Command selection for DeselectCommand
/// </summary>
public class DeselectCommand : ICommand
{
    private readonly MovementSystem _movementSystem;

    public DeselectCommand(MovementSystem movementSystem)
    {
        _movementSystem = movementSystem;
    }

    /// <summary>
    /// Executes the DeselectTileObject from the MovementSystem
    /// </summary>
    public void Execute()
    {
        _movementSystem.DeselectTileObject();
    }
}