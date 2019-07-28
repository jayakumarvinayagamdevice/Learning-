using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqProcess.Set
{
    public interface IDistinctExcercise
    {
        IList<int> Validate();
    }

    public class DistinctExcercise : IDistinctExcercise
    {
        public IList<int> Validate()
        {
            IList<int> registration = new List<int>()
            {
                1,2,3,2,3,4,4,5,6,3,4,5
            };
            var filter = registration.Distinct();
            return filter.ToList<int>();
        }
    }
}
