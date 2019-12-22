using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearTree
{
    abstract class NewYearItem
    {

        internal char View { get; set; }
        internal ConsoleColor Color { get; set; }
        internal int X { get; set; }
        internal int Y { get; set; }
        protected NewYearItem(int x, int y) { Y = y; X = x; }
        NewYearItem(int x, int y, char view, ConsoleColor color)
        {
            X = x; Y = y; Color = color; View = view;
        }
        abstract public void SnowDown();
    }
}
