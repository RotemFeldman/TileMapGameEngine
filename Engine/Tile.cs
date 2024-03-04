using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileMapGameEngine
{
    public abstract class Tile : IPosition
    {
        public delegate void TileEventArgs(Tile sender, TileObject tileObject);
        public abstract TileObject Occupant { get; set; }
        

        public abstract void TryEnter(TileObject tileObject);
        public abstract void Enter(TileObject tileObject);
        public abstract void Exit(TileObject tileObject);

        public abstract void OnTileObjectEnter(TileObject tileObject);
        public abstract void OnTileObjectExit(TileObject tileObject);
        public abstract void OnTileObjectPassThrough(TileObject tileObject);
    }
}
