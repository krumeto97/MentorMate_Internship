﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GreenRedGame
{
    public struct Cell
    {
        public Cell(int value)
        {
            this.Value = value;
        }
        public int Value { get; set; }
    }
}
