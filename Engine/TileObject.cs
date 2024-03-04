using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TileMapGameEngine
{
    public abstract class TileObject : IPosition , INullable
    {
        public abstract bool IsNull { get; }

        public abstract void SetPosition(Vector2 position);
    }
}
