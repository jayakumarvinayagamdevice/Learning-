using System;
using System.Collections.Generic;
using System.Text;

namespace LinqProcess.Set
{
    public interface IIntersectExcersice
    {
        IList<int> Validate();
    }

    public class IntersectExcersice : IIntersectExcersice
    {
        public IList<int> Validate()
        {
            throw new NotImplementedException();
        }
    }
}
