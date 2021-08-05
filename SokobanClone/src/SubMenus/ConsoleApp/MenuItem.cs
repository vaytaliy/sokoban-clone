using SokobanClone.src.Entities;
using SokobanClone.src.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace SokobanClone.src.SubMenus.ConsoleApp
{
    abstract public class MenuItem
    {
        //is a parent class
        public ConsoleKeyboardManager ConsoleKeyboardManager { get; set; }
        public MenuHandler MenuHandler { get; set; }
        public MenuItem(ConsoleKeyboardManager consoleKeyboardManager, MenuHandler menuHandler)
        {
            ConsoleKeyboardManager = consoleKeyboardManager;
            MenuHandler = menuHandler;
        }
    }
}
