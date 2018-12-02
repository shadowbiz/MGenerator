using System;
using System.Collections.Generic;
using System.Linq;

namespace MazeGenerator
{
    public static class Extensions
    {
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source, Random rnd)
        {
            var e = source.ToArray();
            var start = e.Length - 1;
            for (var i = start; i >= 0; i--)
            {
                var swapIndex = rnd.Next(i + 1);
                yield return e[swapIndex];
                e[swapIndex] = e[i];
            }
        }

        public static CellState OppositeWall(this CellState orig)
        {
            return (CellState)(((int)orig >> 2) | ((int)orig << 2)) & CellState.Initial;
        }
    }
}
