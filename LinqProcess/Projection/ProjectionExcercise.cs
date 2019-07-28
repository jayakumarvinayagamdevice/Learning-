using LinqProcess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqProcess.Projection
{
    public class ProjectionExcercise
    {
        public void Start()
        {
            var products = LinqContainers.Products;

            // select all property
            var allFields = products.Select(x => x);
            // specifi
            var productName = products.Select(x => x.ProductName);
            //Anonymous Type 
            var unknownName = products.Select(x => new { x.ProductName, x.UnitPrice });
            // perform calculation
            var currentPrice = products.Select(x => new { UnitPrice = x.UnitPrice + 100 });
            // Index
            var withIndex = products.Select((pro, inx) => new { pro.ProductName, Index = inx });
        }

        public void SelectMany()
        {

        }
    }
}
