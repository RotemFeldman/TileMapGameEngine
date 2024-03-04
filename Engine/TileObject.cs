using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Positioning_TileMapEngine;

namespace TileMapGameEngine
{
    public abstract class TileObject 
    {
        protected delegate void TileObjectEventArgs(TileObject sender, TileObject other);
        protected event TileObjectEventArgs? OnTileObjectLand;
        protected event TileObjectEventArgs? OnTileObjectPass;

        protected abstract Actor Owner { get; }
        protected abstract Position Position { get; }
        
    }
}
