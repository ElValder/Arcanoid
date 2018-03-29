using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Arcanoid
{
    class Program
    {
        public static void Board(){
            Console.BackgroundColor=ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            for (int i=0;i<=80;i++) {
                Console.Write("%");
            }
            Console.WriteLine();
            for (int i = 0; i <= 20; i++)
            { 
                Console.Write("#");
                for (int z=0;z<=78;z++) {
                    Console.Write(" ");
                }
                Console.Write("#");
                Console.WriteLine();
            }          
        }
        static void Main(string[] args)
        {
            Board();

            int x = 1, y = 1, offsetX = 1, offsetY = 1;
            Console.CursorVisible = true;
        
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.Escape:
                            goto End;
                    }
                }
                Console.CursorLeft = x;
                Console.CursorTop = y;
                Thread.Sleep(40);
                Console.Write(" ");

                x += offsetX;
                y += offsetY;
                if (x < 1)
                {
                    Console.Beep(800,10);
                    x = 1;
                    offsetX = -offsetX;
                }
                if (x > 77)
                {
                    Console.Beep(800, 10);
                    x = 77;
                    offsetX = -offsetX;
                }
                if (y <1)
                {
                    Console.Beep(800, 10);
                    y = 1;
                    offsetY = -offsetY;
                }
                if (y > 20)
                {
                    y = 20;
                    offsetY = -offsetY;
                }
            }
        End:;
        }
    }
}
