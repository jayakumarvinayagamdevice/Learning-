using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqProcess.Quantifier
{
    public interface IAnyExcercise
    {
        bool CheckAnyItems(int[] marks);
        bool CheckAnyItems(int[] marks, int filter);
        bool CheckAnyItems(int[] marks, Func<int, bool> predicate);
    }
    public class AnyExcercise : IAnyExcercise
    {
        public bool CheckAnyItems(int[] marks)
        {
            if (marks == null)
                throw new InvalidOperationException();            
            return marks.Any();
        }

        public bool CheckAnyItems(int[] marks, int filter)
        {
            if (marks == null)
                throw new InvalidOperationException();
            return marks.Any(x=> x == filter);
        }

        public bool CheckAnyItems(int[] marks, Func<int, bool> predicate)
        {
            if (marks == null)
                throw new InvalidOperationException();
            return marks.Any(predicate);
        }
    }
}
