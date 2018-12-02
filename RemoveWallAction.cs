using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MazeGenerator
{
    public struct RemoveWallAction
    {
        public Point Neighbour;
        public CellState Wall;
    }
}
