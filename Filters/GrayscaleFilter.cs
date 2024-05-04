using System;

namespace MyPhotoshop
{
    public class GrayscaleFilter : PixelFilter
    {
        public override string ToString() => "Оттенки серого";
        

        public GrayscaleFilter() : base(new EmptyParameters()) { }

        public override Pixel ProcessPixel(Pixel pixel, IParameters parameters)
        {
            var lighteng = 0.2126 * pixel.R + 0.7152 * pixel.G + 0.0722 * pixel.B;
            return new Pixel(lighteng, lighteng, lighteng);
        }
    }
}

