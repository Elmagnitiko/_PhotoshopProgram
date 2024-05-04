using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotoshop
{
    public class EmptyParameters : IParameters
    {
        public ParameterInfo[] GetDesсription() => new ParameterInfo[0];
        
        public void SetValues(double[] values)
        {

        }
    }
}
