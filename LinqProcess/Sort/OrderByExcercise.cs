using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace LinqProcess.Sort
{
    /*
     * IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector);
     * IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer);
     */
    public interface IOrderByExcercise
    {
        IEnumerable<string> SortOrder(string[] country);
        IEnumerable<Student> SortOrder(IList<Student> students);
        IEnumerable<Student> SortOrder(IList<Student> students, Func<Student, string> predicate);
    }

    public class OrderByExcercise : IOrderByExcercise
    {
        public IEnumerable<string> SortOrder(string[] country)
        {            
            return country.OrderBy(x => x); 
        }

        public IEnumerable<Student> SortOrder(IList<Student>students)
        {
            if (students == null || students.Count() < 1)
                throw new ArgumentNullException();
            return students.OrderBy(x => x.Age);
        }

        public IEnumerable<Student> SortOrder(IList<Student> students, Func<Student, string> predicate)
        {
            return students.OrderBy(predicate);
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    
}
