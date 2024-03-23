/// <summary>
/// Command selection for MoveTileObject
/// </summary>
public class MoveTileObjectCommand : IParameterizedCommand
{
    private readonly MovementSystem _movementSystem;
    private readonly int _x;
    private readonly int _y;

    public MoveTileObjectCommand(MovementSystem movementSystem, int x, int y)
    {
        _movementSystem = movementSystem;
        _x = x;
        _y = y;
    }

    /// <summary>
    /// Executes the MoveTileObject from the MovementSystem (with parameters)
    /// </summary>
    public void Execute(int x, int y)
    {
        _movementSystem.MoveTileObject(x, y);
    }

    /// <summary>
    /// Executes the MoveTileObject from the MovementSystem
    /// </summary>
    public void Execute()
    {
        _movementSystem.MoveTileObject(_x, _y);
    }
}