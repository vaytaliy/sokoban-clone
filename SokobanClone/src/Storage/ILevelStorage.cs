using SokobanClone.src.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SokobanClone.src.Storage
{
    public interface ILevelStorage
    {
        // this will be useful for reading from db or anything else
        Level GetLevelByName(string name);
    }
}
