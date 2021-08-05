using SokobanClone.src.Rendering;
using SokobanClone.src.Settings;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Timers;

namespace SokobanClone.src.Entities
{
    //Class which takes control of changing game state and its initialization
    public enum State
    {
        PLAYING = 1,
        MENU = 2,
        PAUSED = 3
    }
    public class GameManager
    {
        public Level CurrentLevel { get; set; }
        public IKeyboardManager KeyboardManager { get; set; }
        public State CurrentState { get; set; } = State.MENU;
        public MenuHandler MenuHandler;
        public string PlayerAction { get; set; }
        public string PressedKeyName { get; set; }
        private bool KeysBlocked = false;
        private System.Timers.Timer GameTimer { get; set; } = new System.Timers.Timer();
        public List<string> InputCommands { get; set; }
        public int GameTime { get; set; } = 0;
        private bool InputLockIsCreated { get; set; } = false;
        public IGameRenderer GameRenderer { get; set; }
        private bool GameJustStarted = true;
        public bool PreventReading { get; set; } = false;
        public Thread ReaderThread { get; set; }


        public GameManager(IKeyboardManager keyboardManager, MenuHandler menuHandler, IGameRenderer gameRenderer)
        {
            KeyboardManager = keyboardManager;
            KeyboardManager.InitializeDefaultKeybindValues(); //TODO if theres saved controls configuration file, then read from config file, else initialize default values
            InputCommands = new List<string>();
            MenuHandler = menuHandler;
            GameRenderer = gameRenderer;
        }

        public void ResetInputLock(Object source, ElapsedEventArgs e)
        {
            KeysBlocked = false;
            InputLockIsCreated = false;
        }

        public void ProcessUserInputs()
        {
            while (!PreventReading)
            {
                //var pressedKey = ((int)Console.ReadKey().Key).ToString();

                var actionTuple = KeyboardManager.GetKeyAction();
                
                var pressedKey = actionTuple.keyCodeString;
                var action = actionTuple.action;
                PressedKeyName = pressedKey;

                if (action != "" && KeysBlocked == false)
                {
                    KeysBlocked = true;
                    if (!InputLockIsCreated)
                    {
                        InputLockIsCreated = true;
                        GameTimer.Interval = 100;
                        GameTimer.Elapsed += ResetInputLock;
                        GameTimer.Start();
                    }
                    
                    PlayerAction = action;
                    //PressedKeyName = pressedKey;
                }

                if (KeysBlocked == false)
                {
                    //PressedKeyName = pressedKey;
                }

                Thread.Sleep(10);
            }
        }

        public void ToggleState()
        {
            switch (CurrentState)
            {
                case State.PAUSED:
                    CurrentState = State.PLAYING;
                    break;
                case State.PLAYING:
                    CurrentState = State.PAUSED;
                    break;
                default:
                    break;
            }
        }

        public void RunGameTick()
        {
            //ProcessUserInputs();
            //KeyIsPressed = true;
            
            if (PlayerAction == "toggle_menu")
            {
                ToggleState();
            }

            if (CurrentState == State.PLAYING)
            {
               HandlePlayerControl();
            }

            if (CurrentState == State.MENU && PressedKeyName != null || GameJustStarted)
            {
                MenuHandler.DisplayMenu(MenuHandler.ActiveMenu, PressedKeyName);
                GameJustStarted = false;
            }

            //wait for next input
            //ProcessUserInputs();
            //KeyIsPressed = false;
            PlayerAction = null; // reset action to nothing after all code executes
            PressedKeyName = null;
            Thread.Sleep(10);
        }

        public void HandlePlayerControl()
        {
            //Console.WriteLine(PlayerAction);

            //foreach (var player in CurrentLevel.Players)
            //{
            //    (int X, int Y) playerPositionChange = player.Move(PlayerAction, CurrentLevel);

            //    if (playerPositionChange.X != 0 || playerPositionChange.Y != 0)
            //    {
            //        //notify the other player about this change

            //        //TODO run renderer
            //        GameRenderer.DisplayGameObjects(CurrentLevel.LevelObjects);
            //    }
            //}
        }
    }
}
