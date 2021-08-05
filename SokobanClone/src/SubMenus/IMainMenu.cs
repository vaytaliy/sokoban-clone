using System;
using System.Collections.Generic;
using System.Text;

namespace SokobanClone.src.SubMenus
{
    public interface IMainMenu
    {
        /*
         *  1. Start
         *  2. Settings
         *  3. Quit
         */
        void SelectStartMenu();
        void SelectSettingsMenu();
        void SelectQuit();
    }
}
