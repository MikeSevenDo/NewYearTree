using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
// Console.WriteLine("֎۝ₒ•†‡║♪●♫█꭛"  ◢◣);
namespace NewYearTree
{
    class Program
    {
        static public List<NewYearItem> ItemsList = new List<NewYearItem>()
        {
            new TreeToy(25, 15),
            new SnowItem(10, 10)

        };

        static void ShowItem(NewYearItem it)
        {
            Console.SetCursorPosition(it.X, it.Y);
            Console.ForegroundColor = it.Color;
            Console.WriteLine(it.View);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.CursorVisible = false;


            while (true)
            {
                foreach (var item in ItemsList)
                {
                    ShowItem(item);
                    Thread.Sleep(200);
                    item.SnowDown();
                }
            }

        }
    }
}
