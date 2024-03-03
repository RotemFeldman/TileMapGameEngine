using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Positioning_TileMapEngine
{
    interface IPosition
    {
        public Vector2 Position { get; set; }

        public void SetPosition(Vector2 position);
    }
}
