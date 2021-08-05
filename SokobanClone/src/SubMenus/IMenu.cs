using SokobanClone.src.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SokobanClone.src.SubMenus
{
    public interface IMenu
    {
        void Render(string pressedKey);
        void HandleKeyPress(string pressedKeyCode);
    }
}
