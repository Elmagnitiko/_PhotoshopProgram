using System;

namespace MyPhotoshop
{
	public class LighteningFilter : PixelFilter
	{
		public override ParameterInfo[] GetParameters()
		{
			return new []
			{
				new ParameterInfo { Name="Коэффициент", MaxValue=10, MinValue=0, Increment=0.1, DefaultValue=1 }
				
			};
		}
		
		public override string ToString ()
		{
			return "Осветление/затемнение";
		}

		public override Pixel ProcessPixel(Pixel original, double[] perams)
		{
			return original * perams[0];
		}
	}
}

