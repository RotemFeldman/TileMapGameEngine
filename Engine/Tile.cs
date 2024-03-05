using TileMapGameEngine.Interfaces;

namespace TileMapGameEngine
{
    public abstract class Tile
    {
        public delegate void TileEventArgs(Tile sender, TileObject tileObject);
        public event TileEventArgs? OnTileObjectLandedEvent;
        public event TileEventArgs? OnTileObjectPassedEvent;

        protected abstract TileObject Occupant { get; set; }
        protected abstract IActor Owner { get;}

        public bool IsEmpty()
        {
            if(Occupant == null) 
                return true;
            return false;
        }        

        public TileObject? GetOccupant()
        {
            if (Occupant == null)
                return null;

            return Occupant;
        }

        public IActor? GetOwner()
        {
            if(Owner == null)
                return null;

            return Owner;
        }

        protected void OnTileObjectLanded(TileObject tileObject) => OnTileObjectLandedEvent?.Invoke(this, tileObject);        
        protected void OnTileObjectPassThrough(TileObject tileObject) => OnTileObjectPassedEvent?.Invoke(this, tileObject);                    
        
    }
}
