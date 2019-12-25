using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearTree
{
    class TreeToy : NewYearItem
    {

        List<ConsoleColor> ColorPanel = new List<ConsoleColor>()
        {
            ConsoleColor.Red,
            ConsoleColor.Yellow,
            ConsoleColor.Magenta,
            ConsoleColor.Blue,
            ConsoleColor.DarkCyan
        };
        Random rand { get; set; }
        public TreeToy(int x, int y, int r) : base(x, y)
        {
            rand = new Random(r);
            Color = ColorPanel[rand.Next(0, 5)];
            View = '֎';
        }
        public override void SnowDown()
        {
            ConsoleColor curColor = this.Color;
            while (curColor == this.Color)
                this.Color = ColorPanel[rand.Next(0, 5)];
        }
    }
}
