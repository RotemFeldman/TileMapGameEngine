public class MovementSystem
{
    /// <summary>
    /// Selects the tile object on a tile map in position (x,y)
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    public void SelectTileObject(int x, int y)
    {
        Console.WriteLine($"Selected object on ({x},{y})");
    }

    /// <summary>
    /// Deselects the current selected tile object
    /// </summary>
    public void DeselectTileObject()
    {
        Console.WriteLine("Object deselected");
    }

    /// <summary>
    /// Moves current selected tile object to position (x,y)
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    public void MoveTileObject(int x, int y)
    {
        Console.WriteLine($"Moved object to ({x},{y})");
    }
}