using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileMapGameEngine
{
    /// <summary>
    /// Represents an enumerator for iterating through the tile map.
    /// </summary>
    internal class TileMapEnumerator : IEnumerator<Tile> , IDisposable
    {
        private Tile[,] map;
        private int width;
        private int height;
        private int currentX;
        private int currentY;

        /// <summary>
        /// Initializes a new instance of the TileMapEnumerator class with the specified tile map.
        /// </summary>
        /// <param name="map">The tile map.</param>
        public TileMapEnumerator(Tile[,] map)
        {
            this.map = map;
            this.width = map.GetLength(0);
            this.height = map.GetLength(1);
            Reset();
        }

        /// <summary>
        /// Gets the current tile in the tile map.
        /// </summary>
        public Tile Current
        {
            get { return map[currentX, currentY]; }
        }

        /// <summary>
        /// Gets the current tile in the tile map.
        /// </summary>
        object IEnumerator.Current => Current;

        /// <summary>
        /// Advances the enumerator to the next tile in the tile map.
        /// </summary>
        /// <returns>true if the enumerator was successfully advanced to the next tile; false if the enumerator has passed the end of the tile map.</returns>
        public bool MoveNext()
        {
            if (currentX < width - 1)
            {
                currentX++;
            }
            else if (currentY < height - 1)
            {
                currentX = 0;
                currentY++;
            }
            else
            {
                return false; // End of iteration
            }
            return true;
        }

        /// <summary>
        /// Sets the enumerator to its initial position, which is before the first tile in the tile map.
        /// </summary>
        private void Reset()
        {
            currentX = -1;
            currentY = 0;
        }

        /// <summary>
        /// Disposes of the resources used by the enumerator.
        /// </summary>
        public void Dispose()
        {

        }

        void IEnumerator.Reset()
        {
            currentX = -1;
            currentY = 0;
        }
    }
}
