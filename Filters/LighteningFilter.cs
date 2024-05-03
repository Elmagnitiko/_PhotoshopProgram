using System;

namespace MyPhotoshop
{
	public class LighteningFilter : IFilter
	{
		public ParameterInfo[] GetParameters()
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
		
		public Photo Process(Photo original, double[] parameters)
		{
			var result=new Photo();
			result.Width=original.Width;
			result.Height=original.Height;
			result.Data=new Pixel[result.Width,result.Height];
			
			for (int x = 0; x < result.Width; x++)
			{
				for (int y = 0; y < result.Height; y++)
				{
					result.Data[x, y] = new Pixel();
					result.Data[x, y].R = original.Data[x, y].R * parameters[0];
                    result.Data[x, y].G = original.Data[x, y].G * parameters[0];
                    result.Data[x, y].B = original.Data[x, y].B * parameters[0];
                }
									
			}
				
			return result;
		}
	}
}

