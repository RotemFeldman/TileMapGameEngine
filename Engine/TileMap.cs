﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileMapGameEngine
{
    public abstract class TileMap
    {
        protected abstract Tile[,] Map { get; set; }

        protected TileMap(int x, int y)
        {

        }
    }
}
