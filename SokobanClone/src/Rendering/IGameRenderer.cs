using SokobanClone.src.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SokobanClone.src.Rendering
{
    public interface IGameRenderer
    {
        void DisplayGameObjects(List<GameObject> gameObjects);
    }
}
