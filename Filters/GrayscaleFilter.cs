using System;

namespace MyPhotoshop
{
	public class GrayscaleFilter : PixelFilter
	{
		public override ParameterInfo[] GetParameters()
		{
			return new ParameterInfo[0];
		}
		
		public override string ToString ()
		{
			return "Оттенки серого";
		}
		
        public override Pixel ProcessPixel(Pixel original, double[] perams)
        {
            var lightness = original.R + original.G + original.B;
            lightness /= 3;
            return new Pixel(lightness, lightness, lightness);
        }
    }
}

