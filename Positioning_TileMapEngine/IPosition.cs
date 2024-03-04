using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Positioning_TileMapEngine
{
    /// <summary>
    /// An interface for objects that have a position in two-dimensional space.
    /// </summary>
    interface IPosition
    {
        int X { get; }
        int Y { get; }

    }
}
