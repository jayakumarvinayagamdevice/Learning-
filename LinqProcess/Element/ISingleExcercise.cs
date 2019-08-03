using System;
using System.Linq;

namespace LinqProcess.Element
{
    /*
        The linq method is used to return a single element from data source
        or we can say from a sequence.        
            
        public static Single<TSource>(this IEnumerable<TSource> source) -- No input parameter
        Note: 
            If the data source is empty or if the data source contain more then one element, 
            then it return exception.

        public static Single<TSource>(this IEnumerable<TSource>, Func<Tsource, bool> predicate) -- one predicate parameter
        Note: It throw an exception while the below condition
            1. If the data source is empty
            2. Condition doesn't satesfy any elements in sequence
            3. Condition satesfies more then one element 
            
        Success: 1..1 – one element matches	
        Thrown Exception: 0 | >1 – elements match 
        Use: If exactly 1 element is expected; not 0 or more than 1
    */
    public interface ISingleExcercise
    {
        int SearchFirstMark(int[] marks);
        int SearchTopMark(int[] marks, int filter);
        int SearchTopMark(int[] marks, Func<int, bool> predicate);
    }

    public class SingleExcercise : ISingleExcercise
    {
        public int SearchFirstMark(int[] marks)
        {
            if (marks == null && marks.Length < 1)
                throw new InvalidOperationException();
            return marks.Single();
        }

        public int SearchTopMark(int[] marks, int filter)
        {
            if (marks == null && marks.Length < 1)
                throw new InvalidOperationException();
            return marks.Single(x => x > filter);
        }

        public int SearchTopMark(int[] marks, Func<int, bool> predicate)
        {
            if (marks == null && marks.Length < 1)
                throw new InvalidOperationException();
            return marks.Single(predicate);
        }
    }
}
