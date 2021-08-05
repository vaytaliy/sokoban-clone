using SokobanClone.src.Entities;
using SokobanClone.src.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace SokobanClone.src.SubMenus.ConsoleApp.StartGame
{
    public class StartOnlineMenu : MenuItem, IStartOnlineMenu, IMenu
    {
        public StartOnlineMenu(ConsoleKeyboardManager consoleKeyboardManager,
            MenuHandler menuHandler) : base(consoleKeyboardManager, menuHandler)
        {

        }

        public void HandleKeyPress(string pressedKeyCode)
        {
            throw new NotImplementedException();
        }

        public void Render(string pressedKey)
        {
            throw new NotImplementedException();
        }
    }
}
