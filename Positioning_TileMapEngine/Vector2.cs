using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Positioning_TileMapEngine
{
    readonly struct Vector2 : IEquatable<Vector2>
    {
        public readonly int X { get; }
        public readonly int Y { get; }


        public Vector2 (int x, int y)
        {
            X = x;
            Y = y;
        }

      

        public override string ToString()
        {
            return $"({X},{Y})";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y) ;
        }


        public bool Equals(Vector2 other)
        {
            if (other.Equals(null))
                return false;

            return (this.X == other.X && this.Y == other.Y);              
        }

        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            if(obj == null)
                return false;

            if(this.GetType() != obj.GetType()) 
                return false;

            var vec = (Vector2)obj;

            return this.X == vec.X && this.Y == vec.Y;
        }

        public static Vector2 operator +(Vector2 a, Vector2 b)
        {
            return new Vector2(a.X + b.X, a.Y + b.Y);
        }

        public static Vector2 operator -(Vector2 a, Vector2 b)
        {
            return new Vector2(a.X - b.X, a.Y - b.Y);
        }
    }
}
