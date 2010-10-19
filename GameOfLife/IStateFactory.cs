using System;
using System.Collections.Generic;

namespace GameOfLife
{
    public interface IStateFactory
    {
        State SetNextTickLifeState(Cell cell);
    }
}