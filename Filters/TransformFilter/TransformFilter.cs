﻿using MyPhotoshop.Filters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotoshop
{
    public class TransformFilter : TransformFilter<EmptyParameters>
    {
        public TransformFilter(string name, 
                               Func<Size, Size> sizeTransformer, 
                               Func<Point, Size, Point> pointTransformer) : 
            base(name, new FreeTransformer(sizeTransformer, pointTransformer)) { }
    }
}
