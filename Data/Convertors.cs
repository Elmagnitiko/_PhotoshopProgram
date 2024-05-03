using System;
using System.Drawing;

namespace MyPhotoshop
{
	public static class Convertors
	{
		public static Photo Bitmap2Photo(Bitmap bmp)
		{
			var photo=new Photo();

			photo.Width=bmp.Width;
			photo.Height=bmp.Height;
			photo.Data=new Pixel[bmp.Width,bmp.Height];

			for (int x = 0; x < bmp.Width; x++)
			{
                for (int y = 0; y < bmp.Height; y++)
                {
                    var pixel = bmp.GetPixel(x, y);
					photo.Data[x, y] = new Pixel();
                    photo.Data[x, y].R = (double)pixel.R / 255;
                    photo.Data[x, y].G = (double)pixel.G / 255;
                    photo.Data[x, y].B = (double)pixel.B / 255;
                }
            }
				
			return photo;
		}
		
		static int ToChannel(double val)
		{
            if (val<0 || val>1)
                throw new Exception(string.Format("Wrong channel value {0} (the value must be between 0 and 1", val));
			return (int)(val * 255);
		}
		
		public static Bitmap Photo2Bitmap(Photo photo)
		{
			var bmp=new Bitmap(photo.Width,photo.Height);
			for (int x = 0; x < bmp.Width; x++)
			{
                for (int y = 0; y < bmp.Height; y++)
				{
                    bmp.SetPixel(x, y, Color.FromArgb(
                        ToChannel(photo.Data[x, y].R),
                        ToChannel(photo.Data[x, y].G),
                        ToChannel(photo.Data[x, y].B)));
                }
                    
            }
			
			return bmp;
		}
	}
}

