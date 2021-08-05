using SokobanClone.src.Entities;
using SokobanClone.src.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace SokobanClone.src.SubMenus.ConsoleApp
{
    public class SettingsMenu : MenuItem, ISettingsMenu, IMenu
    {
        public SettingsMenu(ConsoleKeyboardManager consoleKeyboardManager,
            MenuHandler menuHandler) : base(consoleKeyboardManager, menuHandler)
        {

        }

        public void Render(string pressedKey)
        {
            throw new NotImplementedException();
        }

        public void HandleKeyPress(string pressedKeyCode)
        {
            throw new NotImplementedException();
        }
    }
}
