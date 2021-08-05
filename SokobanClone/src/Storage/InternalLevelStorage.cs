using SokobanClone.src.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SokobanClone.src.Storage
{


    public class InternalLevelStorage : ILevelStorage
    {
        Dictionary<string, Level> Levels = new Dictionary<string, Level>()
        {
            { "TESTLEVEL", new Level(
                    boxes: new List<Box> { new Box((5, 4)), new Box((5, 6)) },
                    floors: new List<Floor> { new Floor((4, 4)), new Floor((4, 6)) },
                    walls: new List<Wall> { new Wall((3, 4)), new Wall((3, 6)) },
                    targets: new List<Target> { new Target((1, 2)), new Target((1, 3)) },
                    startingPlayersPosition: new List<(int StartX, int StartY)> { (4, 4), (4, 6) })
            }
        };

        public Level GetLevelByName(string name)
        {
            Level foundLevel;

            if (!Levels.TryGetValue(name, out foundLevel))
            {
                return null;
            }

            return foundLevel;
        }
    }
}
