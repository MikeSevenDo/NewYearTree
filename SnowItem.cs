using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace NewYearTree
{
    internal class SnowItem : NewYearItem
    {
        public SnowItem(int x, int y) : base(x,y)
        {
            this.View = '*';
            this.Color = ConsoleColor.Cyan;
        }
        public override void SnowDown()
        {
            Random r = new Random();
            Y++;
            if (this.Y > 20)
            {
                this.Y = 0;
                this.X = r.Next(0, 20);
            }
        }
    }
}
