using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TileMapGameEngine.Interfaces;

namespace TileMapGameEngine
{
    public class Actor : IActor
    {
        public enum Actors
        {
            None,
            PlayerOne,
            PlayerTwo,
        }
    }
}
