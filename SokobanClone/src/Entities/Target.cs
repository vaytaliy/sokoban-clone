using System;
using System.Collections.Generic;
using System.Text;

namespace SokobanClone.src.Entities
{
    public class Target : GameObject
    {
        public Target((int StartX, int StartY) startingLocationOnTheLevel) : base(startingLocationOnTheLevel)
        {
        }
    }
}
