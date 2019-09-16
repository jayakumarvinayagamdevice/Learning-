using Decorator;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DecoratorStart
{
    class Program
    {
        static void Main(string[] args)
        {
            //Decorator
            //DecoratorStartUp decoratorStartUp = new DecoratorStartUp();
            //decoratorStartUp.Start();


            /*
             * 
             * static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(
             *      this IEnumerable<TOuter> outer, 
             *      IEnumerable<TInner> inner, 
             *      Func<TOuter, TKey> outerKeySelector, 
             *      Func<TInner, TKey> innerKeySelector,
             *      Func<TOuter, TInner, TResult> resultSelector);
             * **/
            List<Triangle> triangles = new List<Triangle>() {
                new Triangle()
                {
                    Side = 2,
                    Height = 2
                },
                new Triangle()
                {
                    Side = 6,
                    Height = 7
                },
                new Triangle()
                {
                    Side = 2,
                    Height = 2
                },
                new Triangle()
                {
                    Side = 3,
                    Height = 2
                }
            };
            var temp = triangles.Distinct(new TriangleAreaEqualityComparer()).ToList();

            IList<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };
            var single1 = intList.Single(x => x < 11);
            var single2 = intList.Single(x => x > 80);
            var singleOrDefault1 = intList.SingleOrDefault(x => x < 10);
            var singleOrDefault2 = intList.SingleOrDefault(x => x > 55);

            var first1 = intList.First(x => x < 11);
            var first2 = intList.First(x => x > 80);
            var firstOrDefault1 = intList.FirstOrDefault(x => x < 10);
            var firstOrDefault2 = intList.FirstOrDefault(x => x > 45);
            var firstOrDefault3 = intList.FirstOrDefault(x => x > 95);
        }
    }

    public class Triangle
    {
        public int Height { get; set; }
        public int Side { get; set; }
        public int Area { get {
                return (Height * Side) / 2;
            } }
    }
    public class TriangleAreaEqualityComparer : IEqualityComparer<Triangle>
    {
        public bool Equals(Triangle x, Triangle y)
        {
            return x.Area == y.Area;
        }

        public int GetHashCode(Triangle obj)
        {
            return obj.Area.GetHashCode();
        }
    }
}
