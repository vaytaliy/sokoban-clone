using SokobanClone.src.Entities;
using SokobanClone.src.Settings;
using SokobanClone.src.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace SokobanClone.src.SubMenus.ConsoleApp.StartGame
{
    public class StartMenu : MenuItem, IStartMenu, IMenu 
    {

        public StartMenu(ConsoleKeyboardManager consoleKeyboardManager,
            MenuHandler menuHandler) : base(consoleKeyboardManager, menuHandler)
        { }

        public void Render(string pressedKey)
        {
            Console.WriteLine(
                "===Start menu===\n" +
                "1. Start offline game\n" +
                "2. Online game\n" +
                "3. Back to main menu\n" +
                "\n");

            //ConsoleKeyboardManager.TestPrint();
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
                MenuHandler.DisplayMenu(MenuType.StartOfflineMenu, null);
            }
            else if (keyCode == ConsoleKey.D2 || keyCode == ConsoleKey.NumPad2)
            {
                MenuHandler.DisplayMenu(MenuType.StartOnlineMenu, null);
            }
            else if (keyCode == ConsoleKey.D3 || keyCode == ConsoleKey.NumPad3)
            {
                MenuHandler.DisplayMenu(MenuType.MainMenu, null);
            }
        }

        public void SelectStartOfflineMenu()
        {
            Console.WriteLine("selected start offline menu");
        }

        public void SelectStartOnlineMenu()
        {
            throw new NotImplementedException();
        }
    }
}
