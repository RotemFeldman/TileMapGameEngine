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
    internal class TileMapEnumerator<T> : IEnumerator<T> , IDisposable
    {
        private T[,] _map;
        private int _width;
        private int _height;
        private int _currentX;
        private int _currentY;

        /// <summary>
        /// Initializes a new instance of the TileMapEnumerator class with the specified tile map.
        /// </summary>
        /// <param name="_map">The tile map.</param>
        public TileMapEnumerator(T[,] _map)
        {
            this._map = _map;
            this._width = _map.GetLength(0);
            this._height = _map.GetLength(1);

            _currentX = -1;
            _currentY = 0;
        }

        /// <summary>
        /// Gets the current tile in the tile map.
        /// </summary>
        public T Current
        {
            get { return _map[_currentX, _currentY]; }
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
            if (_currentX < _width - 1)
            {
                _currentX++;
            }
            else if (_currentY < _height - 1)
            {
                _currentX = 0;
                _currentY++;
            }
            else
            {
                return false; // End of iteration
            }
            return true;
        }

        /// <summary>
        /// Disposes of the resources used by the enumerator.
        /// </summary>
        public void Dispose()
        {
            // Dispose implementation if needed
        }

        /// <summary>
        /// Resets the enumerator to its initial position, which is before the first tile in the tile map.
        /// </summary>
        void IEnumerator.Reset()
        {
            new NotSupportedException();
        }

        /// <summary>
        /// Sets the enumerator to its initial position, which is before the first tile in the tile map.
        /// </summary>
        private void Reset()
        {
            new NotSupportedException();
        }
    }
}
