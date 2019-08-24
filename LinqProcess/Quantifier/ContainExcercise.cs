using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqProcess.Quantifier
{
    /*
     * bool Contains<TSource>(this IEnumerable<TSource> source, TSource value);
     * bool Contains<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer);
     * **/
    public interface IContainExcercise
    {
        bool CheckAllItems(int[] marks);
        bool CheckAllItems(int[] marks, int filter);
    }
    public class ContainExcercise : IContainExcercise
    {
        public bool CheckAllItems(int[] marks)
        {
            if (marks == null)
                throw new InvalidOperationException();
            return marks.Contains(45);
        }

        public bool CheckAllItems(int[] marks, int filter)
        {
            if (marks == null || marks.Length < 1)
                throw new InvalidOperationException();
            return marks.Contains(filter);
        }
    }
}
