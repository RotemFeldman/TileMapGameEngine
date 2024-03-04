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
    public interface IPosition
    {
        /// <summary>
        /// The X-coordinate of the position.
        /// </summary>
        int X { get; }

        /// <summary>
        /// The Y-coordinate of the position.
        /// </summary>
        int Y { get; }
        
    }
}
