﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileMapGameEngine
{
    public abstract class TileMap
    {
        public abstract Tile[] map { get; }
    }
}