using LinqProcess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqProcess.Filtering
{
    public class FilteringExcercise
    {
        public void Start()
        {
            var products = LinqContainers.Products;
            var greater300 = products.Where(x => x.UnitPrice > 300);
            // using predicatre
            Func<Product, bool> predicate = x => x.UnitPrice > 300;
            var greaterByUsingPredicate = products.Where(predicate);
            // By method
            var greaterByUsingExternalMethod = products.Where(x=> CheckUnitPrice(x.UnitPrice));
        }

        public static bool CheckUnitPrice(decimal number)
        {
            if (number > 300)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
