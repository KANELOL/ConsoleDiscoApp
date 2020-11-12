using System;
using System.Collections.Generic;
using System.Text;

namespace PixelClass
{
    class Line
    {
        public Sprite Sprite { get; }

        public Line(int x, int y, int length, ConsoleColor color)
        {
            var pixels = new Pixel[length];
            for (var i = 0; i < length; i++)
            {
                var px = x + i;
                var py = y;
                pixels[i] = new Pixel(px,py, color);
            }
            Sprite = new Sprite(pixels);
        }

        public void Show()
        {
            Sprite.Show();
        }

        public void Delete()
        {
            Sprite.Delete();
        }
    }
}
