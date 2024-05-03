using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotoshop
{
    public class Pixel
    {
        private double _r;
        private double _g;
        private double _b;
        
        public double R
        {
            get => _r;
            set => _r = SetProperty(value);
        }
        public double G
        {
            get => _g;
            set => _g = SetProperty(value);
        }
        public double B
        {
            get => _b; 
            set => _b = SetProperty(value);
        }

        public static double Trim(double value)
        {
            if (value > 1)
            {
                return 1;
            }
            if (value < 0)
            {
                return 0;
            }
            return value;
        }

        private double SetProperty(double value)
        {
            if (!IsValidProperty(value))
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Value has to be more than zero and less than 1.");
            }

            return value;
        }

        private bool IsValidProperty(double value)
        {
            return value >= 0 && value <= 1;
        }

    }
}
