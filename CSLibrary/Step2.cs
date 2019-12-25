using System;
using System.Collections.Generic;
using System.Linq;

namespace CSLibrary.Step2
{
    public class Vector2
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override bool Equals(object other) => Equals(other as Vector2);
        public bool Equals(Vector2 other) => other != null && X == other.X && Y == other.Y;
    }
}
