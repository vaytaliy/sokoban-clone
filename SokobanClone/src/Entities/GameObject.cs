using System;
using System.Collections.Generic;
using System.Text;

#nullable enable

namespace SokobanClone.src.Entities
{
    public class GameObject
    {
        public (int X, int Y)? Position { get; set; }
        public GameObject((int StartX, int StartY)? startingLocationOnTheLevel)
    {
            Position = startingLocationOnTheLevel;
        }
    }
}
