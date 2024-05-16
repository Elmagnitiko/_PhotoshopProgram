
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotoshop
{
    public abstract class ParametrizedFilter<TParameters> : IFilter where TParameters : IParameters ,new()
    {
        IParametersHandler<TParameters> handler = new SimpleParametersHandler<TParameters>();
        
        public ParameterInfo[] GetParameters()
        {
            return handler.GetDescription();
        }
        

        public Photo Process(Photo original, double[] values)
        {
            var parameters = handler.CreateParameters(values);
            return Process(original, parameters);
        }

        public abstract Photo Process(Photo original, TParameters parameters);
    }
}
