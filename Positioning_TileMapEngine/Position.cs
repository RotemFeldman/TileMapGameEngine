using System.Diagnostics.CodeAnalysis;

namespace Positioning_TileMapEngine
{
    public readonly struct Position : IPosition , IEquatable<Position>
    {
        /// <summary>
        /// Gets the X-coordinate of the position.
        /// </summary>
        public int X { get;  }

        /// <summary>
        /// Gets the Y-coordinate of the position.
        /// </summary>
        public int Y { get;  }

        /// <summary>
        /// Initializes a new instance of the Position struct with the specified coordinates.
        /// </summary>
        /// <param name="x">The X-coordinate of the position.</param>
        /// <param name="y">The Y-coordinate of the position.</param>
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }


        /// <summary>
        /// Returns a string representation of the position.
        /// </summary>
        public override string ToString()
        {
            return $"({X},{Y})";
        }

        /// <summary>
        /// Computes a hash code for the position.
        /// </summary>
        /// 
        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current position.
        /// </summary>
        /// <param name="other">The position to compare with the current position.</param>
        public bool Equals(Position other)
        {
            return (this.X == other.X && this.Y == other.Y);
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current position.
        /// </summary>
        /// <param name="obj">The object to compare with the current position.</param>
        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            if (obj == null)
                return false;

            if (this.GetType() != obj.GetType())
                return false;

            var pos = (Position)obj;

            return this.X == pos.X && this.Y == pos.Y;
        }

        /// <summary>
        /// Adds two positions together.
        /// </summary>
        /// <param name="a">The first position to add.</param>
        /// <param name="b">The second position to add.</param>
        /// <returns>A new position that represents the sum of the input positions.</returns>
        public static Position operator +(Position a, Position b)
        {
            return new Position(a.X + b.X, a.Y + b.Y);
        }

        /// <summary>
        /// Subtracts one position from another.
        /// </summary>
        /// <param name="a">The position to subtract from.</param>
        /// <param name="b">The position to subtract.</param>
        /// <returns>A new position that represents the difference between the input positions.</returns>
        public static Position operator -(Position a, Position b)
        {
            return new Position(a.X - b.X, a.Y - b.Y);
        }

        /// <summary>
        /// Determines whether two specified positions are equal.
        /// </summary>
        /// <param name="left">The first position to compare.</param>
        /// <param name="right">The second position to compare.</param>
        /// <returns>true if the X and Y coordinates of <paramref name="left"/> are equal to the X and Y coordinates of <paramref name="right"/>; otherwise, false.</returns>
        /// <remarks>
        /// Two positions are considered equal if their X and Y coordinates are equal.
        /// </remarks>
        public static bool operator ==(Position left, Position right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Determines whether two specified positions are not equal.
        /// </summary>
        /// <param name="left">The first position to compare.</param>
        /// <param name="right">The second position to compare.</param>
        /// <returns>true if the X and Y coordinates of <paramref name="left"/> are not equal to the X and Y coordinates of <paramref name="right"/>; otherwise, false.</returns>
        /// <remarks>
        /// Two positions are considered not equal if their X and Y coordinates are not equal.
        /// </remarks>
        public static bool operator !=(Position left, Position right)
        {
            return !(left == right);
        }
    }
}
