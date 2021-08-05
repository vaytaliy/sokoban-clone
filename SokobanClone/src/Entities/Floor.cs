using System;
using System.Collections.Generic;
using System.Text;

namespace SokobanClone.src.Entities
{
    public class Floor : GameObject
    {
        public Floor((int StartX, int StartY) startingLocationOnTheLevel) : base(startingLocationOnTheLevel)
        {
        }
    }
}
