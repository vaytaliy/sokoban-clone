using SokobanClone.src.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SokobanClone.src.Rendering
{
    public class ConsoleGameRenderer : IGameRenderer
    {
        public void DisplayGameObjects(List<GameObject> gameObjects)
        {
            foreach (GameObject gameObject in gameObjects)
            {
                //TODO: do some displaying operation
            }
        }
    }
}
