using SokobanClone.src.Entities;
using SokobanClone.src.Settings;
using SokobanClone.src.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace SokobanClone.src.SubMenus.ConsoleApp
{
    public class MainMenu : MenuItem, IMainMenu, IMenu
    {

        public MainMenu(ConsoleKeyboardManager consoleKeyboardManager,
            MenuHandler menuHandler) : base(consoleKeyboardManager, menuHandler)
        {

        }

        public void SelectQuit()
        {
            Environment.Exit(1);
        }

        public void SelectSettingsMenu()
        {
            throw new NotImplementedException();
        }

        public void SelectStartMenu()
        {
            MenuHandler.DisplayMenu(MenuType.StartMenu, null);
        }

        public void Render(string pressedKey)
        {
            Console.WriteLine(
                "===Main menu===\n" +
                "1. Start\n" +
                "2. Settings\n" +
                "3. Quit\n" +
                "\n");
            
            HandleKeyPress(pressedKey);
        }

        public void HandleKeyPress(string pressedKeyCode)
        {
            if (pressedKeyCode == null)
            {
                return;
            }

            var keyCode = ConsoleKeyboardManager.ConvertStringToKey(pressedKeyCode).Key;

            if (keyCode == ConsoleKey.D1 || keyCode == ConsoleKey.NumPad1)
            {
                SelectStartMenu();
            }

            else if (keyCode == ConsoleKey.D2 || keyCode == ConsoleKey.NumPad2)
            {
                MenuHandler.DisplayMenu(MenuType.SettingsMenu, null);
            }

            else if (keyCode == ConsoleKey.D3 || keyCode == ConsoleKey.NumPad3)
            {
                SelectQuit();
            }
        }
    }
}
