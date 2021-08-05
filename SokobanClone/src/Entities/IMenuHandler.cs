using SokobanClone.src.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace SokobanClone.src.Entities
{
    public interface IMenuHandler
    {
        MenuType ActiveMenu { get; set; }
        void DisplayMenu(MenuType menuType, string keyboardAction);
    }
}
