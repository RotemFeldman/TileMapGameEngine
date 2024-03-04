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
        /// <summary>
        /// Gets or sets the position of the object.
        /// </summary>
        /// <remarks>
        /// The position is represented by a <see cref="IntVector2"/> instance.
        /// </remarks>
        public IntVector2 Position { get; set; }

        /// <summary>
        /// Sets the position of the object to the specified coordinates.
        /// </summary>
        /// <param name="position">The new position of the object.</param>
        public void SetPosition(IntVector2 position);
    }
}
