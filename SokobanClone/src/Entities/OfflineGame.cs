using SokobanClone.src.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace SokobanClone.src.Entities
{
    
    public class OfflineGame
    {
        public List<string> PlayerNames { get; set; }
        public Level PreparedLevel { get; set; }

        public InternalLevelStorage _internalLevelStorage;
        public MenuHandler _menuHandler;

        public OfflineGame(InternalLevelStorage internalLevelStorage, MenuHandler menuHandler)
        {
            PlayerNames = new List<string>();
            _internalLevelStorage = internalLevelStorage;
            _menuHandler = menuHandler;
        }

        public Level FetchLevelFrom(string storageType, string levelName)
        {
            Level foundLevel = null;

            if (storageType == "internal")
            {
                foundLevel = _internalLevelStorage.GetLevelByName(levelName);

            } else if (storageType == "web")
            {
                //TBD 
            }

            if (foundLevel != null)
            {
                return foundLevel;
            }

            return null;
        }

        public void InitializeNewPlayer(string playerName)    // accepts 2 maxiumum
        {
            PreparedLevel.TryAddPlayer(new Player(playerName, null));
        }

        public void TestLevel()
        {
            PreparedLevel = new Level(
                    boxes: new List<Box> { new Box((5, 4)), new Box((5, 6)) },
                    floors: new List<Floor> { new Floor((4, 4)), new Floor((4, 6)) },
                    walls: new List<Wall> { new Wall((3, 4)), new Wall((3, 6)) },
                    targets: new List<Target> { new Target((1, 2)), new Target((1, 3)) },
                    startingPlayersPosition: new List<(int StartX, int StartY)> {(4,4), (4,6) }
                );
        }

        /*The steps is as follows
        *  - click on the menu and initialize OfflineGame constructor
        *  - write name of level (the game will look for level data)
        *  - write player name/names (if the level allows to spawn 2 players)
        *  - initialize GameManager (pass level, controls settings, menu handler, renderer)
        *  [Note: if on any step this fails, the offline game value will be set to NULL to dispose object]
        *
        *
        */
    }
}
