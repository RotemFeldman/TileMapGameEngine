using Positioning_TileMapEngine;
using TileMapGameEngine.Interfaces;

namespace TileMapGameEngine
{
    public abstract class TileObject : ICloneable
    {
        public delegate void TileObjectEventArgs(TileObject sender, TileObject other);
        public event TileObjectEventArgs? OnTileObjectLandedEvent;
        public event TileObjectEventArgs? OnTileObjectPassedEvent;
       
        protected abstract IActor? Owner { get; }
        protected abstract IPosition Position { get; }

        public abstract object Clone();        
             
        protected virtual void OnTileObjectLanded(TileObject other) => OnTileObjectLandedEvent?.Invoke(this, other);
        protected virtual void OnTileObjectPassed(TileObject other) => OnTileObjectPassedEvent?.Invoke(this, other);
                   
        
    }
}
