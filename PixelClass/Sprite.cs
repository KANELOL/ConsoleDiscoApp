using System;
using System.Collections.Generic;
using System.Text;

namespace PixelClass
{
    class Sprite
    {
        private Pixel[] _pixels;

        public Sprite(Pixel[] pixels)
        {
            _pixels = pixels;
        }

        public void Show()
        {
            foreach (var pixel in _pixels)
            {
                pixel.Show();
            }
        }

        public void Delete()
        {
            foreach (var pixel in _pixels)
            {
                pixel.Delete();
            }
        }
    }
}
