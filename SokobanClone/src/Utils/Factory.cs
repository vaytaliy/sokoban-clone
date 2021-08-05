using SokobanClone.src.Entities;
using SokobanClone.src.Rendering;
using SokobanClone.src.Settings;
using SokobanClone.src.SubMenus;
using SokobanClone.src.SubMenus.ConsoleApp;
using SokobanClone.src.SubMenus.ConsoleApp.StartGame;
using System;
using System.Collections.Generic;
using System.Text;

namespace SokobanClone.src.Utils
{
    public enum CreationTypes
    {
        Console,
        TBD
    }
    class Factory
    {
        //this can be refactored to produce classes in the same method
        
        public IKeyboardManager GetKeyboardManager(CreationTypes creationType)
        {
            if (creationType == CreationTypes.Console)
            {
                return new ConsoleKeyboardManager();
            }

            return null;
            //other cases for non console keyboard manager
        }

        public IGameRenderer GetGameRenderer(CreationTypes creationType)
        {
            if (creationType == CreationTypes.Console)
            {
                return new ConsoleGameRenderer();
            }

            return null;
        }

        public Dictionary<string, IMenu> GetMenuCollection(CreationTypes creationType, IKeyboardManager keyboardManager, MenuHandler menuHandler)
        {
            if (creationType == CreationTypes.Console)
            {
                var consoleKeyboardManager = (ConsoleKeyboardManager)keyboardManager;

                var menuMenu = new MainMenu(consoleKeyboardManager, menuHandler);
                var pauseMenu = new PauseMenu(consoleKeyboardManager, menuHandler);
                var settingsMenu = new SettingsMenu(consoleKeyboardManager, menuHandler);
                var startMenu = new StartMenu(consoleKeyboardManager, menuHandler);
                var startOfflineMenu = new StartOfflineMenu(consoleKeyboardManager, menuHandler);
                var startOnlineMenu = new StartOnlineMenu(consoleKeyboardManager, menuHandler);

                var menuCollection = new Dictionary<string, IMenu>()

                //menuHandler
                {
                    {"main_menu", menuMenu },
                    {"pause_menu", pauseMenu },
                    {"settings_menu", settingsMenu },
                    {"start_menu", startMenu },
                    {"start_offline_menu", startOfflineMenu },
                    {"start_online_menu", startOnlineMenu }
                };
                
                return menuCollection;
            }

            return null;
        }
    }
}
