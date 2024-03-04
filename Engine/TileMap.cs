using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileMapGameEngine
{
    public abstract class TileMap
    {
        public abstract Tile[,] Map { get; set; }

        public abstract TileMap CreateMap(int x, int y);
    }
}
