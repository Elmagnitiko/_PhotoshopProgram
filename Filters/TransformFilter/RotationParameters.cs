using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotoshop
{
    public class RotationParameters : IParameters
    {
        public double Angle { get; set; }

        public ParameterInfo[] GetDesсription()
        {
            return new[]
            {
                new ParameterInfo { Name="Angle", MaxValue=360, MinValue=0, Increment=5, DefaultValue=0 }
            };
        }

        public void SetValues(double[] values) => Angle = values[0];
        
    }
}
