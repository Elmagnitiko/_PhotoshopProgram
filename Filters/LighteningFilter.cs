using System;

namespace MyPhotoshop
{
    public class LighteningFilter : PixelFilter
    {
        public override string ToString() => "Осветление/затемнение";
        

        public LighteningFilter() : base(new LighteningParameters()) { }

        public override Pixel ProcessPixel(Pixel pixel, IParameters parameters) => pixel * (parameters as LighteningParameters).Coefficient;
    }
}

