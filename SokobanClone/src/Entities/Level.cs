using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#nullable enable

namespace SokobanClone.src.Entities
{
    public class Level
    {
        public List<GameObject> LevelObjects;
        public List<Box> Boxes { get; set; }
        public List<Floor> Floors { get; set; }
        public List<Target> Targets { get; set; }
        public List<Wall>? Walls { get; set; }
        public List<Player> Players { get; set; }
        public List<(int StartX, int StartY)> StartingPlayersPosition { get; set; }
        public Level(List<Box> boxes,
            List<Floor> floors,
            List<Target> targets,
            List<Wall>? walls,
            List<(int StartX, int StartY)> startingPlayersPosition)
        {
            Boxes = boxes;
            Floors = floors;
            Targets = targets;
            Walls = walls;
            Players = new List<Player>();
            LevelObjects = new List<GameObject>();
            StartingPlayersPosition = startingPlayersPosition;
            ToGameObjectList();
        }

        public void TryAddPlayer(Player player)
        {
            if (Players.Count + 1 <= StartingPlayersPosition.Count && Players.Count + 1 <= 2) //Check if starting positions allow for this number of players, max 2 players
            {
                Players.Add(player);
                player.PlayerTag = $"p{Players.Count}";
                player.Position = (
                    X: StartingPlayersPosition[Players.Count - 1].StartX, 
                    Y: StartingPlayersPosition[Players.Count - 1].StartY);
            }          
        }

        private void ToGameObjectList()
        {
            LevelObjects = Boxes.Concat<GameObject>(Floors)
                .Concat(Walls)
                .Concat(Targets)
                .Concat(Players)
                .ToList();
        }
    }
}
