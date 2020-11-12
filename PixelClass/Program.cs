using System;
using System.Collections.Generic;
using System.Threading;
using System.Media;

namespace PixelClass
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool showMap = true;
            Console.WriteLine("DISCO!!");

            while (showMap)
               
            {
                for (int i = 0; i < 10; i++)
                {
                    var line1 = new Line(10 + i, i*2, 20, ConsoleColor.Red);
                    line1.Show();
                    
                }
                for (int i = 0; i < 10; i++)
                {
                            var line2 = new Line(10 + i, i * 2 + 1, 20, ConsoleColor.Blue);
                            line2.Delete();
                }
                Console.Beep(60, 100);
                Console.Beep(200, 100);
                Console.Beep(532, 100);
                
                Console.Beep(250, 100);
               
                Console.Beep(332, 100);
                

                {
                    for (int i = 0; i < 10; i++)
                    {
                        var line2 = new Line(10+i, i * 2 + 1, 20, ConsoleColor.Blue);
                        line2.Show();
                    }
                }
                for (int i = 0; i < 10; i++)
                {
                    var line1 = new Line(10 + i, i * 2, 20, ConsoleColor.Red);
                    line1.Delete();
                }
                Console.Beep(50, 1000);
                Console.Beep(250, 100);
                //Thread.Sleep(100);
                Console.Beep(432, 100);
                //Thread.Sleep(50);
                Console.Beep(532, 100);
                //Thread.Sleep(50);
                Console.Beep(652, 1000);

            }
        }
    }

}
