using SokobanClone.src.Entities;
using SokobanClone.src.Settings;
using SokobanClone.src.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SokobanClone.src.SubMenus.ConsoleApp.StartGame
{
    enum OfflineSelection
    {
        LevelName = 1,
        PlayerOne = 2,
        PlayerTwo = 3, //leave empty to play alone

    }
    public class StartOfflineMenu : MenuItem, IStartOfflineMenu, IMenu
    {
        private string ErrorText { get; set; } = "";
        private string LevelName { get; set; } = "";
        private string HelperText { get; set; } = "Level selection menu";
        private OfflineSelection Selection { get; set; } = OfflineSelection.LevelName;
        public StartOfflineMenu(ConsoleKeyboardManager consoleKeyboardManager,
            MenuHandler menuHandler) : base(consoleKeyboardManager, menuHandler)
        {

        }

        public void HandleKeyPress(string pressedKeyCode)
        {
            throw new NotImplementedException();
        }

        public void Render(string pressedKey)
        {

            Console.WriteLine(
                "===Offline game menu===\n" +
                "Level selection\n" +
                $"{ErrorText}\n" +
                $"======\n" +
                $"{HelperText}\n" +
                $"{LevelName}\n");

            var keyboardManager = (ConsoleKeyboardManager)MenuHandler.GameManager.KeyboardManager;
            //Console.WriteLine(LevelName);
            var x = pressedKey;
            Console.WriteLine(x);
            
            var keyboardResult = keyboardManager.ProcessConsoleInput(LevelName, pressedKey);
            //if (pressedKey != null)
            //{
            //    LevelName += pressedKey;
            //    Refresh();
            //}

            LevelName = keyboardResult.ModifiedText;

            if (keyboardResult.Instruction == ConsoleKeyboardManager.ConsoleInstruction.Back)
            {
                RedirectToStartMenu();
                return;
            }

            if (keyboardResult.Instruction == ConsoleKeyboardManager.ConsoleInstruction.Continue)
            {
                if (pressedKey != null)
                {
                    Refresh();
                }
                return;
            }

            if (keyboardResult.Instruction == ConsoleKeyboardManager.ConsoleInstruction.Finish)
            {
                var levelSearchResultSuccessful = HandleLevelSelection();

                if (!levelSearchResultSuccessful)
                {
                    ErrorText = "Error: Specified level doesn't exist, try again or type Q level to go to main menu";
                }

                LevelName = "";
                Refresh();
            }
        }

        public void Refresh()
        {
            MenuHandler.DisplayMenu(MenuType.StartOfflineMenu, null);
        }

        public bool HandleLevelSelection()
        {
            var foundLevel = MenuHandler.InternalLevelStorage.GetLevelByName(LevelName);

            if (foundLevel != null)
            {
                OfflineGame offlineGame = new OfflineGame(MenuHandler.InternalLevelStorage, MenuHandler);
                return true;
            }
            return false;
        }

        public void RedirectToStartMenu()
        {
            ResetMenuData();
            MenuHandler.DisplayMenu(MenuType.StartMenu, null);
        }

        public void ResetMenuData()
        {
            ErrorText = "";
            LevelName = "";
        }
    }
}
