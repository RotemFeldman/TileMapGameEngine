using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Positioning_TileMapEngine
{
    /// <summary>
    /// Represents a two-dimensional vector with integer X and Y coordinates.
    /// </summary>
    readonly struct Vector2 : IEquatable<Vector2> 
    {
        /// <summary>
        /// Gets the X-coordinate of the vector.
        /// </summary>
        public readonly int X { get; }

        /// <summary>
        /// Gets the Y-coordinate of the vector.
        /// </summary>
        public readonly int Y { get; }

 
        /// <summary>
        /// Initializes a new instance of the Vector2 struct with the specified coordinates.
        /// </summary>
        /// <param name="x">The X-coordinate of the vector.</param>
        /// <param name="y">The Y-coordinate of the vector.</param>
        public Vector2 (int x, int y)
        {
            X = x;
            Y = y;
        }


        /// <summary>
        /// Returns a string representation of the vector.
        /// </summary>
        public override string ToString()
        {
            return $"({X},{Y})";
        }

        /// <summary>
        /// Computes a hash code for the vector.
        /// </summary>
        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y) ;
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current vector.
        /// </summary>
        /// <param name="other">The vector to compare with the current vector.</param>
        public bool Equals(Vector2 other)
        {
            return (this.X == other.X && this.Y == other.Y);              
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current vector.
        /// </summary>
        /// <param name="obj">The object to compare with the current vector.</param>
        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            if(obj == null)
                return false;

            if(this.GetType() != obj.GetType()) 
                return false;

            var vec = (Vector2)obj;

            return this.X == vec.X && this.Y == vec.Y;
        }

        /// <summary>
        /// Adds two vectors together.
        /// </summary>
        /// <param name="a">The first vector to add.</param>
        /// <param name="b">The second vector to add.</param>
        /// <returns>A new vector that represents the sum of the input vectors.</returns>
        public static Vector2 operator +(Vector2 a, Vector2 b)
        {
            return new Vector2(a.X + b.X, a.Y + b.Y);
        }

        /// <summary>
        /// Subtracts one vector from another.
        /// </summary>
        /// <param name="a">The vector to subtract from.</param>
        /// <param name="b">The vector to subtract.</param>
        /// <returns>A new vector that represents the difference between the input vectors.</returns>
        public static Vector2 operator -(Vector2 a, Vector2 b)
        {
            return new Vector2(a.X - b.X, a.Y - b.Y);
        }

        /// <summary>
        /// Determines whether two specified vectors are equal.
        /// </summary>
        /// <param name="left">The first vector to compare.</param>
        /// <param name="right">The second vector to compare.</param>
        /// <returns>true if the X and Y coordinates of <paramref name="left"/> are equal to the X and Y coordinates of <paramref name="right"/>; otherwise, false.</returns>
        /// <remarks>
        /// Two vectors are considered equal if their X and Y coordinates are equal.
        /// </remarks>
        public static bool operator ==(Vector2 left, Vector2 right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Determines whether two specified vectors are not equal.
        /// </summary>
        /// <param name="left">The first vector to compare.</param>
        /// <param name="right">The second vector to compare.</param>
        /// <returns>true if the X and Y coordinates of <paramref name="left"/> are not equal to the X and Y coordinates of <paramref name="right"/>; otherwise, false.</returns>
        /// <remarks>
        /// Two vectors are considered not equal if their X and Y coordinates are not equal.
        /// </remarks>
        public static bool operator !=(Vector2 left, Vector2 right)
        {
            return !(left == right);
        }
    }
}
