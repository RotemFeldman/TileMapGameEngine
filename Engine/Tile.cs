using TileMapGameEngine.Interfaces;

namespace TileMapGameEngine
{
    /// <summary>
    /// Represents a tile on a game board.
    /// </summary>
    public abstract class Tile
    {
        /// <summary>
        /// Delegate for tile events.
        /// </summary>
        /// <param name="sender">The tile sending the event.</param>
        /// <param name="tileObject">The tile object associated with the event.</param>
        public delegate void TileEventArgs(Tile sender, TileObject tileObject);

        /// <summary>
        /// Event triggered when a tile object lands on this tile.
        /// </summary>
        public event TileEventArgs? OnTileObjectLandedEvent;

        /// <summary>
        /// Event triggered when a tile object passes through this tile.
        /// </summary>
        public event TileEventArgs? OnTileObjectPassedEvent;

        /// <summary>
        /// Event triggered when a tile object leaves this tile.
        /// </summary>
        public event TileEventArgs? OnTileObjectLeftEvent;

        /// <summary>
        /// Gets or sets the occupant of this tile.
        /// </summary>
        protected abstract TileObject? Occupant { get; set; }

        /// <summary>
        /// Gets the owner of this tile.
        /// </summary>
        protected abstract IActor? Owner { get;}

        /// <summary>
        /// Checks if the tile is empty.
        /// </summary>
        /// <returns>True if the tile is empty; otherwise, false.</returns>
        public bool IsEmpty()
        {
            if(Occupant == null) 
                return true;
            return false;
        }

        /// <summary>
        /// Gets the occupant of this tile.
        /// </summary>
        /// <returns>The occupant of the tile.</returns>
        public TileObject? GetOccupant()
        {
            if (Occupant == null)
                return null;

            return Occupant;
        }

        /// <summary>
        /// Gets the owner of this tile.
        /// </summary>
        /// <returns>The owner of the tile.</returns>
        public IActor? GetOwner()
        {
            if(Owner == null)
                return null;

            return Owner;
        }

        /// <summary>
        /// Raises the event when a tile object lands on this tile.
        /// </summary>
        /// <param name="tileObject">The tile object that landed on the tile.</param>
        protected void OnTileObjectLanded(TileObject tileObject) => OnTileObjectLandedEvent?.Invoke(this, tileObject);

        /// <summary>
        /// Raises the event when a tile object passes through this tile.
        /// </summary>
        /// <param name="tileObject">The tile object that passed through the tile.</param>
        protected void OnTileObjectPassedThrough(TileObject tileObject) => OnTileObjectPassedEvent?.Invoke(this, tileObject);

        /// <summary>
        /// Raises the event when a tile object leaves this tile.
        /// </summary>
        /// <param name="tileObject">The tile object that left the tile.</param>
        protected void OnTileObjectLeft(TileObject tileObject)
        {
            OnTileObjectLeftEvent?.Invoke(this, tileObject);           
            SetOccupantToNull();
        }

        /// <summary>
        /// Sets the occupant of this tile to null.
        /// </summary>
        private void SetOccupantToNull()
        {
            Occupant = null;
        }
        
    }
}
