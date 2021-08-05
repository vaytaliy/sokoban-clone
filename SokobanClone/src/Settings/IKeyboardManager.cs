using System;
using System.Collections.Generic;
using System.Text;

namespace SokobanClone.src.Settings
{
    public interface IKeyboardManager
    {
        void InitializeDefaultKeybindValues();
        void ReadSavedKeybindValues();
        void InitializeSavedKeybindValues();
        (string keyCodeString, string action) GetKeyAction();
        //bool ChangeKey(string targetedControl, ConsoleKey newKey);
    }
}
