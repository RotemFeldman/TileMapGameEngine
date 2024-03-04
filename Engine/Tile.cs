using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TileMapGameEngine.Interfaces;

namespace TileMapGameEngine
{
    public abstract class Tile : IRenderable
    {
        protected delegate void TileEventArgs(Tile sender, TileObject tileObject);
        protected event TileEventArgs? OnTileObjectEntered;
        protected event TileEventArgs? OnTileObjectPassedThrough;

        protected abstract TileObject Occupant { get; set; }
        protected abstract IActor Owner { get;}

        protected virtual bool IsEmpty()
        {
            if(Occupant == null) 
                return true;
            return false;
        }
        
        

        protected virtual void OnTileObjectEnter(TileObject tileObject)
        {
            OnTileObjectEntered?.Invoke(this, tileObject);
        }

        protected virtual void OnTileObjectPassThrough(TileObject tileObject)
        {
            OnTileObjectPassedThrough?.Invoke(this, tileObject);
        }
    }
}
