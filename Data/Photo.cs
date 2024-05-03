using System;
using System.Windows.Forms;

namespace MyPhotoshop
{
	public class Photo
	{
		public readonly int Width;
		public readonly int Height;

		private readonly Pixel[,] Data;

		public Pixel this[int x, int y]
		{
			get => Data[x, y];
		}

		public Photo(int width, int heigh)
		{
            Width = width;
			Height = heigh;
			Data = new Pixel[Width, Height];

			for (int x = 0; x < width; x++)
			{
				for (int y = 0; y < heigh; y++)
				{
					Data[x, y] = new Pixel();
				}
			}
        }
	}
}

