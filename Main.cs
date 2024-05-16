using MyPhotoshop.Filters;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace MyPhotoshop
{
	class MainClass
	{
        [STAThread]
		public static void Main (string[] args)
		{
			var window=new MainWindow();

			window.AddFilter(new PixelFilter<LighteningParameters>
                (
				    "Осветеление/затенение",
				    (pixel,parameters) => pixel*parameters.Coefficient)
                );

			window.AddFilter(new PixelFilter<EmptyParameters>
                (
                    "Оттени серого",
                    (pixel, parameters) =>
				    {
                        var lighteng = 0.2126 * pixel.R + 0.7152 * pixel.G + 0.0722 * pixel.B;
                        return new Pixel(lighteng, lighteng, lighteng);
                    }
                ));

            window.AddFilter(new TransformFilter<RotationParameters>
                (
                    "Free rotation", 
                    new RotateTransformer()
                ));

            window.AddFilter(new TransformFilter
                (
                    "Rotate counterclockwise",
                    size => new Size(size.Height, size.Width),
                    (point, size) => new Point(point.Y, point.X))
                );

            window.AddFilter(new TransformFilter
                (
                    "Horizontal reflect",
                    size => size,
                    (point, size) => new Point(size.Width - point.X - 1, point.Y))
                );

            Application.Run (window);
		}
	}
}
