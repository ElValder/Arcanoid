using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcanoid
{
    class Program
    {
        static void Main(string[] args) { 
       
                int x = 0, y = 0, offsetX = 1, offsetY = 1;
                Console.CursorVisible = false;
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
                    Console.Write("0");
                    x += offsetX;
                    y += offsetY;
                    if (x < 0)
                    {
                        x = 0;
                        offsetX = -offsetX;
                    }
                    else if (x > 40)
                    {
                        x = 40;
                        offsetX = -offsetX;
                    }
                    else if (y < 0)
                    {
                        y = 0;
                        offsetY = -offsetY;
                    }
                    else if (y > 40)
                    {
                        y = 40;
                        offsetY = -offsetY;
                    }
                }
        End:;
            }
        }
    }
