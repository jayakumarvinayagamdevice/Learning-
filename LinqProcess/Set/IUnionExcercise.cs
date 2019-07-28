using System;
using System.Collections.Generic;
using System.Text;

namespace LinqProcess.Set
{
    public interface IUnionExcercise
    {
        IList<int> Validate();
    }

    public class UnionExcercise : IUnionExcercise
    {
        public IList<int> Validate()
        {
            throw new NotImplementedException();
        }
    }
}
