using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqProcess
{
    public class Excercise
    {
        List<int> ages = new List<int>() {
                                25, 34, 55, 78, 20, 16, 5, 77, 80
                            };
        public void Start()
        {          
            // get greater then 20 
            var filters = from age in ages
                          where age >= 20
                          select age;
            foreach (var item in filters)
            {
                Console.WriteLine($"{item}");
            }

            var methodFilters = ages.Where(x => x >= 20).Select(x => x);
            foreach (var item in methodFilters)
            {
                Console.WriteLine($"{item}");
            }
            // mixed
            var mixed = (from age in ages
                         where age >= 20
                         select age).Sum();

            Console.WriteLine($"{mixed}");
        }    
        
        public void IQuerableTest()
        {
            var methodFilters = ages.AsQueryable().Where(x => x >= 20).Select(x => x);
            foreach (var item in methodFilters)
            {
                Console.WriteLine($"{item}");
            }
        }
       

    }
}
