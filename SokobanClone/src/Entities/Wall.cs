using System;
using System.Collections.Generic;
using System.Text;

namespace SokobanClone.src.Entities
{
    public class Wall : GameObject
    {
        public Wall((int StartX, int StartY) startingLocationOnTheLevel) : base(startingLocationOnTheLevel)
        {
        }
    }
}
