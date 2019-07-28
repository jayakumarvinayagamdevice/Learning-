using System;
using System.Collections.Generic;
using System.Text;

namespace LinqProcess.Set
{
    public interface IExceptExcercise
    {
        IList<int> Validate(IList<int> first, IList<int> second);
    }

    public class ExceptExcercise : IExceptExcercise
    {
        public IList<int> Validate(IList<int> first, IList<int> second)
        {
            throw new NotImplementedException();
        }
    }
}
