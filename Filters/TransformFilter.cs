using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotoshop
{
    public class TransformFilter : ParametrizedFilter<EmptyParameters>
    {
        readonly Func<Size, Size> sizeTransform;
        readonly Func<Point, Size, Point> pointTransform;
        readonly string name;

        public TransformFilter(string name, Func<Size, Size> sizeTransform, Func<Point, Size, Point> pointTransform)
        {
            this.name = name;
            this.sizeTransform = sizeTransform;
            this.pointTransform = pointTransform;
        }

        public override string ToString()
        {
            return name;
        }

        public override Photo Process(Photo original, EmptyParameters parameters)
        {
            var oldSize = new Size(original.Width, original.Height);
            var newSize = sizeTransform(oldSize);
            var result = new Photo(newSize.Width, newSize.Height);

            for (int x = 0; x < newSize.Width; x++)
            {
                for (int y = 0; y < newSize.Height; y++)
                {
                    var point = new Point(x, y);
                    var oldPoint = pointTransform(point, oldSize);
                    result[x, y] = original[oldPoint.X, oldPoint.Y];
                }
            }
            return result;
        }
    }
}
