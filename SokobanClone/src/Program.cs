using SokobanClone.src.Entities;
using SokobanClone.src.Rendering;
using SokobanClone.src.Settings;
using SokobanClone.src.Storage;
using SokobanClone.src.SubMenus;
using SokobanClone.src.Utils;
using System;
using System.Collections.Generic;
using System.Threading;

namespace SokobanClone
{
    class Program
    {
        //public static State CurrentState { get; set; } = State.MENU;
        static void Main(string[] args)
        {

            //=================================
            //Initializing step
            //=================================
            
            Factory factory = new Factory();
            IKeyboardManager keyboardManager = factory.GetKeyboardManager(CreationTypes.Console);
            IGameRenderer gameRenderer = factory.GetGameRenderer(CreationTypes.Console);
            
            InternalLevelStorage internalLevelStorage = new InternalLevelStorage(); // has no relation to console app, can be made outside factory
            MenuHandler menuHandler = new MenuHandler(internalLevelStorage); // get access to reading level data

            Dictionary<string, IMenu> menuCollection = factory.GetMenuCollection(CreationTypes.Console, keyboardManager, menuHandler);
            
            menuHandler.MainMenu = menuCollection["main_menu"];
            menuHandler.PauseMenu = menuCollection["pause_menu"];
            menuHandler.SettingsMenu = menuCollection["settings_menu"];
            menuHandler.StartMenu = menuCollection["start_menu"];
            menuHandler.StartOfflineMenu = menuCollection["start_offline_menu"];
            menuHandler.StartOnlineMenu = menuCollection["start_online_menu"];

            

            GameManager gameManager = new GameManager(
                keyboardManager: keyboardManager,
                menuHandler: menuHandler,
                gameRenderer: gameRenderer);

            menuHandler.GameManager = gameManager;

            Thread readerThread = new Thread(new ThreadStart(gameManager.ProcessUserInputs));
            gameManager.ReaderThread = readerThread;

            readerThread.Start();
            
            //=================================
            //Processing changes steps
            //=================================

            while (true)
            {   
                gameManager.RunGameTick();
            }
        }
    }
}

// this is a code. Done :)

//game:
// - floor
// - wall 
// - storage location

//player: 
// - move up and down a cell
// - player cant walk into a wall
// - cant walk on crate if its pushed against a wall

//box:
// - cannot be pulled
// - can be pushed
// - cannot be pushed to wall or other box 
// - number of boxes equals the number of storage locations

//target:
// - some floor squares are marked as storage locations
// - must place all boxes there to complete a game

//floor (what does it have)
// - different color
// - coordinates

//wall (what does it have)
// - different color
// - coordinates

