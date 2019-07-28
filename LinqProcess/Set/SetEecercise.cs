using LinqProcess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqProcess.Set
{
    public class SetEecercise
    {
        public void Start()
        {
            List<int> intCollection = new List<int>()
            {
                1,2,3,2,3,4,4,5,6,3,4,5
            };

            
            var unique = intCollection.Distinct();

            var products = LinqContainers.Products;
        }
    }
}
