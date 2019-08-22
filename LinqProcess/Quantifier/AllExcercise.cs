using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqProcess.Quantifier
{
    /**
         Quantifier operations produce a  boolean value to indicate whether all or a portion of
            elements satisfy a specific condition.
         # All 
         # Any
         # Contains
    */
    public interface IAllExcercise
    {
        bool CheckAllItems(int[] marks);
        bool CheckAllItems(int[] marks, int filter);
        bool CheckAllItems(int[] marks, Func<int, bool> predicate);
    }

    /*
     * Determines whether all elements of a sequence satisfy a condition.
     * public static bool All<TSource>(this IEnumerable<TSource>, Func<TSource, bool> predicate)
     */
    public class AllExcercise : IAllExcercise
    {
        public bool CheckAllItems(int[] marks)
        {
            if (marks == null || marks.Length < 1)
                throw new InvalidOperationException();
            return marks.All(x => x > 30);
        }

        public bool CheckAllItems(int[] marks, int filter)
        {
            if (marks == null || marks.Length < 1)
                throw new InvalidOperationException();
            return marks.All(x => x > filter);
        }

        public bool CheckAllItems(int[] marks, Func<int, bool> predicate)
        {
            if (marks == null || marks.Length < 1)
                throw new InvalidOperationException();
            return marks.All(predicate);
        }
    }
}
