using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SokobanClone.src.Settings
{
    public class ConsoleKeyboardManager : IKeyboardManager
    {
        public Dictionary<ConsoleKey, string> KeyBinds = new Dictionary<ConsoleKey, string>(); //To get key by string name: (ConsoleKey)43  (number which represents this key
        public enum ConsoleInstruction
        {
            Finish = 1,
            Continue = 2,
            Back = 3,
        }
        public ConsoleKeyboardManager()
        { }

        public void InitializeDefaultKeybindValues()
        {
            KeyBinds.Add(ConsoleKey.W, "p1_up");
            KeyBinds.Add(ConsoleKey.A, "p1_left");
            KeyBinds.Add(ConsoleKey.S, "p1_down");
            KeyBinds.Add(ConsoleKey.D, "p1_right");

            KeyBinds.Add(ConsoleKey.NumPad8, "p2_up");
            KeyBinds.Add(ConsoleKey.NumPad4, "p2_left");
            KeyBinds.Add(ConsoleKey.NumPad3, "p2_down");
            KeyBinds.Add(ConsoleKey.NumPad6, "p2_right");

            KeyBinds.Add(ConsoleKey.Escape, "toggle_menu");
        }

        public void ReadSavedKeybindValues()
        {

        }

        public void InitializeSavedKeybindValues()
        {

        }
        //remove method below
        public void TestPrint()
        {
            Console.WriteLine("instantiated");
        }

        //Use regular expression to check for alphabetical inputs A,B,C,D,E ... etc
        public (string ModifiedText, ConsoleInstruction Instruction) ProcessConsoleInput(string originalText, string newInput)
        {

            var keyString = "";
            var modifiedText = originalText;

            if (newInput != null)
            {
                keyString = ConvertStringToKey(newInput).Key.ToString();
            }
            else
            {
                return (originalText, ConsoleInstruction.Continue);
            }

            if (keyString == "Backspace")
            {
                if (originalText.Length > 0)
                {
                    modifiedText = originalText.Substring(0, originalText.Length - 1);
                }
                return (modifiedText, ConsoleInstruction.Continue);

            }
            else if (keyString == "OemMinus")
            {
                modifiedText += "-";
                return (modifiedText, ConsoleInstruction.Continue);
            }

            else if (keyString.StartsWith('D'))
            {
                modifiedText += keyString.Substring(1, keyString.Length - 1);
                return (modifiedText, ConsoleInstruction.Continue);
            }
            else if (keyString == "Enter")
            {
                return (originalText, ConsoleInstruction.Finish);
            }
            else if (keyString == "Escape")
            {
                return (originalText, ConsoleInstruction.Back);
            } 
            else if (Regex.Match(keyString, "^[A-Z]$").Success)
            {
                return (modifiedText += keyString, ConsoleInstruction.Continue);
            }
            else
            {
                return (originalText, ConsoleInstruction.Continue);
            }
        }

        //TODO write ChangeKey method so that some control is set to another key

        /// <summary>
        /// <para>
        /// Will try to bind new key from enum
        /// </para>
        /// </summary>
        /// <returns> true if binding succeeded, fail otherwise</returns>

        public bool ChangeKey(string targetedControl, ConsoleKey newKey)
        {
            return false;
        }

        public (int Number, ConsoleKey Key) ConvertStringToKey(string stringKeyRepresentation)
        {
            var numericCode = int.Parse(stringKeyRepresentation);
            var keyCode = (ConsoleKey)numericCode;

            return (Number: numericCode, Key: keyCode);
        }

        public (string keyCodeString, string action) GetKeyAction()
        {
            //int x = 4;
            //int z = 2;
            //x = z + 3;
            //x = 5
            var keyCodeString = ((int)Console.ReadKey().Key).ToString();

            ConsoleKey keyCode = ConvertStringToKey(keyCodeString).Key;

            string action;

            try
            {
                action = KeyBinds[keyCode];
            }
            catch (Exception)
            {
                return (keyCodeString, "");
            }

            if (action != null)
            {
                return (keyCodeString, action);
            }

            return (keyCodeString, "");
        }
    }
}
