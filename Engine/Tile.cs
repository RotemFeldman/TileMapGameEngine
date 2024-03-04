using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileMapGameEngine
{
    public abstract class Tile 
    {
        protected delegate void TileEventArgs(Tile sender, TileObject tileObject);
        protected event TileEventArgs? OnTileObjectEntered;
        protected event TileEventArgs? OnTileObjectExited;
        protected event TileEventArgs? OnTileObjectPassedThorugh;

        protected abstract TileObject Occupant { get; set; }
        protected abstract Actor Owner { get;}
        
        protected virtual bool IsEmpty()
        {
            if (Occupant == null)
                return true;

            return false;
        }
        

        protected abstract void OnTileObjectEnter(TileObject tileObject);
        protected abstract void OnTileObjectExit(TileObject tileObject);
        protected abstract void OnTileObjectPassThrough(TileObject tileObject);
    }
}
