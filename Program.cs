using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

// Console.WriteLine("֎۝ₒ•†‡║♪●♫█꭛"  ◢◣);
namespace NewYearTree
{
    class Program
    {
        static public List<string> Tree = new List<string>()
        {
            @"          /\ ",
            @"         //\\",
            @"        ///\\\",
            @"        ///\\\" ,
            @"       ////\\\\" ,
            @"      /////\\\\\" ,
            @"     //////\\\\\\" ,
            @"      /////\\\\\" ,
            @"     //////\\\\\\" ,
            @"    ///////\\\\\\\" ,
            @"   ////////\\\\\\\\" ,
            @"     //////\\\\\\" ,
            @"    ///////\\\\\\\" ,
            @"   ////////\\\\\\\\" ,
            @"  /////////\\\\\\\\\" ,
            @" //////////\\\\\\\\\\" ,
            @"///////////\\\\\\\\\\\" ,
            @"        ||||||" ,
            @"        ||||||" ,
            @"        ||||||"
        };
        static public List<NewYearItem> ItemsList = new List<NewYearItem>()
        {
            new TreeToy(16 + 15, 6, 1),
            new TreeToy(12 + 15, 10, 2),
            new TreeToy(18 + 15, 11, 3),
            new TreeToy(11 + 15, 13, 3),
            new TreeToy(19 + 15, 16 , 3),
            new TreeToy(10 + 15, 18, 6),
            new TreeToy(20 + 15, 20 , 7),
            new SnowItem(0, 1, 20),
            new SnowItem(0, 2, 20),
            new SnowItem(0, 3, 20),
            new SnowItem(0, 4, 20),
            new SnowItem(0, 5, 20),
            new SnowItem(0, 6, 20),
            new SnowItem(0, 7, 20),
            new SnowItem(0, 8, 20),
            new SnowItem(0, 9, 20),
            new SnowItem(0, 10, 20),
            new SnowItem(0, 11, 20),
            new SnowItem(0, 12, 20),
            new SnowItem(0, 13, 20),
            new SnowItem(0, 14, 20),
            new SnowItem(0, 15, 20),
            new SnowItem(0, 16, 20),
            new SnowItem(0, 17, 20),
            new SnowItem(0, 18, 20),
            new SnowItem(0, 19, 20),
            new SnowItem(0, 20, 20),

            new SnowItem(42, 1, 60),
            new SnowItem(42, 2, 60),
            new SnowItem(42, 3, 60),
            new SnowItem(42, 4, 60),
            new SnowItem(42, 5, 60),
            new SnowItem(42, 6, 60),
            new SnowItem(42, 7, 60),
            new SnowItem(42, 8, 60),
            new SnowItem(42, 9, 60),
            new SnowItem(42, 10, 60),
            new SnowItem(42, 11, 60),
            new SnowItem(42, 12, 60),
            new SnowItem(42, 13, 60),
            new SnowItem(42, 14, 60),
            new SnowItem(42, 15, 60),
            new SnowItem(42, 16, 60),
            new SnowItem(42, 17, 60),
            new SnowItem(42, 18, 60),
            new SnowItem(42, 19, 60),
            new SnowItem(42, 20, 60)
        };
        static SoundPlayer Music = new SoundPlayer();

        static void ShowItem(NewYearItem it)
        {
            Console.SetCursorPosition(it.X, it.Y);
            Console.ForegroundColor = it.Color;
            Console.WriteLine(it.View);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.CursorVisible = false;
            Console.SetWindowSize(60, 25);
            Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
            //Music.Load();
            //Music.Play();

            int i = 5;
            foreach (string line in Tree)
            {
                Console.SetCursorPosition(20, i++);
                if (i < 23)
                    Console.ForegroundColor = ConsoleColor.Green;
                else Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(line);
            }

            while (true)
            {
                foreach (var item in ItemsList)
                {
                    item.SnowDown();
                    ShowItem(item);
                }
                Thread.Sleep(200);
            }

        }
    }
}
