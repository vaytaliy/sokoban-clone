using System;
using System.Collections.Generic;
using System.Text;

#nullable enable

namespace SokobanClone.src.Entities
{
    public class Player : GameObject
    {
        public string PlayerTag { get; set; }
        public string PlayerNumber { get; set; } = ""; //p1, p2   <- will be overwritten on level init

        public Player(string playerTag, (int StartX, int StartY)? startingLocationOnTheLevel) : base(startingLocationOnTheLevel)
        {
            PlayerTag = playerTag;
        }

        internal (int X, int Y) Move(string playerAction, Level level) //TODO: Box is dependent on player, and level, this player will define some logic to the box
        {
            if (playerAction == PlayerTag + "_" + "up") //needs to validate against level objects
            {
                return (0, 1);
            }
            else if (playerAction == PlayerTag + "_" + "down")
            {
                return (0, -1);
            }
            else if (playerAction == PlayerTag + "_" + "right")
            {
                return (1, 0);
            }
            else if (playerAction == PlayerTag + "_" + "left")
            {
                return (-1, 0);
            }

            return (0, 0);
        }
    }
}
