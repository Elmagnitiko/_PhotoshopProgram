using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotoshop
{
    public abstract class ParametrizedFilter : IFilter
    {
        readonly IParameters _parameters;

        protected ParametrizedFilter(IParameters parameters) => _parameters = parameters;
        

        public ParameterInfo[] GetParameters() => _parameters.GetDesсription();
        

        public Photo Process(Photo original, double[] values)
        {
            _parameters.SetValues(values);
            return Process(original, _parameters);
        }

        public abstract Photo Process(Photo original, IParameters parameters);
    }
}
