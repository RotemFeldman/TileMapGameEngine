using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Positioning_TileMapEngine;

namespace TileMapGameEngine
{
    /// <summary>
    /// Represents an abstract class for a tile map.
    /// </summary>
    public abstract class TileMap<T> where T : Tile, IEnumerable<Tile> 
    {
        /// <summary>
        /// Gets or sets the map of tiles.
        /// </summary>
        protected abstract T[,] Map { get; set; }

        /// <summary>
        /// Gets or sets the width of the tile map.
        /// </summary>
        protected int Width { get; set; }
        /// <summary>
        /// Gets or sets the height of the tile map.
        /// </summary>
        protected int Height { get; set; }

        /// <summary>
        /// Initializes a new instance of the TileMap class with the specified width and height.
        /// </summary>
        /// <param name="width">The width of the tile map.</param>
        /// <param name="height">The height of the tile map.</param>
        protected TileMap(int width, int height)
        {
            Width = width;
            Height = height;
            Map = new T[Width, Height];
        }

        /// <summary>
        /// Initializes a new instance of the TileMap class with the specified tile map.
        /// </summary>
        /// <param name="map">The tile map.</param>
        protected TileMap(T[,] map)
        {
            Map = map;
            Width = map.GetLength(0);
            Height = map.GetLength(1);
        }

        /// <summary>
        /// Gets or sets the tile at the specified position.
        /// </summary>
        /// <param name="position">The position of the tile.</param>
        /// <returns>The tile at the specified position.</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown when the specified position is out of range.</exception>
        public T this[Position position]
        {
            get => Map[position.X, position.Y];
            set => Map[position.X,position.Y] = value;
        }

        /// <summary>
        /// Gets or sets the tile at the specified coordinates.
        /// </summary>
        /// <param name="x">The x-coordinate of the tile.</param>
        /// <param name="y">The y-coordinate of the tile.</param>
        /// <returns>The tile at the specified coordinates.</returns>
        public T this[int x, int y]
        {
            get
            {
                if (x < 0 || x >= Width || y < 0 || y >= Height)
                {
                    throw new IndexOutOfRangeException("TileMap coordinates are out of range.");
                }

                return Map[x, y];
            }
            set
            {
                if (x < 0 || x >= Width || y < 0 || y >= Height)
                {
                    throw new IndexOutOfRangeException("TileMap coordinates are out of range.");
                }

                Map[x, y] = value;
            }
        }

        /// <summary>
        /// Returns an enumerator that iterates through the tile map.
        /// </summary>
        /// <returns>An enumerator that can be used to iterate through the tile map.</returns>
        public IEnumerator<T> GetEnumerator()
        {
            return new TileMapEnumerator<T>(Map);
        }
        
    }
}
