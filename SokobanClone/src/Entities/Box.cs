using System;
using System.Collections.Generic;
using System.Text;

namespace SokobanClone.src.Entities
{
    public class Box : GameObject
    {
        public Box((int StartX, int StartY) startingLocationOnTheLevel) : base(startingLocationOnTheLevel)
        {
        }
    }
}
