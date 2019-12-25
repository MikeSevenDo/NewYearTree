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
        int StartPosition { get; set; }
        int FinishPosition {get;set;}
        public SnowItem(int x, int y, int f) : base(x,y)
        {
            Random r = new Random();
            this.View = '*';
            this.Color = ConsoleColor.Cyan;
            X = r.Next(x, f);
            StartPosition = x;
            FinishPosition = f;
        }
        public override void SnowDown()
        {
            Console.SetCursorPosition(this.X, this.Y);
            Console.WriteLine(' ');
            Random r = new Random();
            Y++;
            if (this.Y > 20)
            {
                this.Y = 0;
                this.X = r.Next(this.StartPosition, this.FinishPosition);
            }
        }
    }
}
