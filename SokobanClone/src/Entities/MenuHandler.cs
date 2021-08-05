using SokobanClone.src.Storage;
using SokobanClone.src.SubMenus;
using SokobanClone.src.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace SokobanClone.src.Entities
{

    public class MenuHandler
    {
        public MenuType ActiveMenu { get; set; } = MenuType.MainMenu;
        public IMenu MainMenu { get; set; }
        public IMenu PauseMenu { get; set; }
        public IMenu SettingsMenu { get; set; }
        public IMenu StartMenu { get; set; }
        public IMenu StartOfflineMenu { get; set; }
        public IMenu StartOnlineMenu { get; set; }
        public InternalLevelStorage InternalLevelStorage { get; }
        public GameManager GameManager { get; set; }

        public MenuHandler(InternalLevelStorage internalLevelStorage)
        {
            InternalLevelStorage = internalLevelStorage;
        }

        public void DisplayMenu(MenuType newMenuToShow, string pressedButtonCode)
        {

            //if (pressedButtonCode != null || GameJustStarted)
            //{
            Console.Clear();
            
            //ActiveMenu = newMenuToShow;
            ActiveMenu = newMenuToShow;
            switch (newMenuToShow)
            {
                case MenuType.MainMenu:
                    MainMenu.Render(pressedButtonCode);
                    break;
                case MenuType.PauseMenu:
                    PauseMenu.Render(pressedButtonCode);
                    break;
                case MenuType.SettingsMenu:
                    SettingsMenu.Render(pressedButtonCode);
                    break;
                case MenuType.StartMenu:
                    //Environment.Exit(1);
                    StartMenu.Render(pressedButtonCode);
                    break;

                case MenuType.StartOfflineMenu:
                    StartOfflineMenu.Render(pressedButtonCode);
                    break;
                case MenuType.StartOnlineMenu:
                    StartOnlineMenu.Render(pressedButtonCode);
                    break;
                default:
                    break;
            }
        }
    }
}
