/// <summary>
/// Command selection for SelectCommand
/// </summary>
public class SelectCommand : IParameterizedCommand
{
    private readonly MovementSystem _movementSystem;
    private readonly int _x;
    private readonly int _y;

    public SelectCommand(MovementSystem movementSystem, int x, int y)
    {
        _movementSystem = movementSystem;
        _x = x;
        _y = y;
    }

    /// <summary>
    /// Executes the SelectCommand from the MovementSystem (with parameters)
    /// </summary>
    public void Execute(int x, int y)
    {
        _movementSystem.SelectTileObject(x, y);
    }

    /// <summary>
    /// Executes the MoveTileObject from the MovementSystem
    /// </summary>
    public void Execute()
    {
        _movementSystem.SelectTileObject(_x, _y);
    }
}