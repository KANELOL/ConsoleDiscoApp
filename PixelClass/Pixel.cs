using System;
using System.Collections.Generic;
using System.Text;

namespace PixelClass
{
    class Pixel
    {

        private ConsoleColor _color;
        private int _x;
        private int _y;

        public Pixel(int x, int y, ConsoleColor color)
        {
            _color = color;
            _x = x;
            _y = y;
        }

        public void Show()
        {
            Console.CursorTop = _y;
            Console.CursorLeft = _x;
            Console.ForegroundColor = _color;
            Console.Write("█");
        }

        public void Delete()
        {
            Console.CursorTop = _y;
            Console.CursorLeft = _x;
            Console.Write(" ");
        }
    }
}
