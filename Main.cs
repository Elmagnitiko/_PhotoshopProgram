using System;
using System.Windows.Forms;

namespace MyPhotoshop
{
	class MainClass
	{
        [STAThread]
		public static void Main (string[] args)
		{
			var window=new MainWindow();
			window.AddFilter(new PixelFilter<LighteningParameters>(
				"Осветеление/затенение",
				(pixel,parameters) => pixel*parameters.Coefficient));


			window.AddFilter(new PixelFilter<EmptyParameters>(
                "Оттени серого",
                (pixel, parameters) =>
				{
                    var lighteng = 0.2126 * pixel.R + 0.7152 * pixel.G + 0.0722 * pixel.B;
                    return new Pixel(lighteng, lighteng, lighteng);
                }));
            Application.Run (window);
		}
	}
}
