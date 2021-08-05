using System;
using System.Collections.Generic;
using System.Text;

namespace SokobanClone.src.SubMenus
{
    public interface IStartMenu
    {
        /*
         *  - Start
         *  - Settings
         *  - Quit
         */
        void SelectStartOfflineMenu();
        void SelectStartOnlineMenu();
    }
}
