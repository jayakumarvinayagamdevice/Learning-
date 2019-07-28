using LinqProcess.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinqProcess.Set
{
    public class StudentComparer : IEqualityComparer<Product>
    {
        public bool Equals(Product x, Product y)
        {
            //First check if both object reference are equal then return true
            if (object.ReferenceEquals(x, y))
            {
                return true;
            }
            //If either one of the object refernce is null, return false
            if (object.ReferenceEquals(x, null) || object.ReferenceEquals(y, null))
            {
                return false;
            }
            //Comparing all the properties one by one
            return x.Category == y.Category && x.ProductID == y.ProductID
                && x.ProductName == y.ProductName && x.UnitPrice == y.UnitPrice
                && x.UnitsInStock == y.UnitsInStock;
        }

        public int GetHashCode(Product obj)
        {
            //If obj is null then return 0
            if (obj == null)
            {
                return 0;
            }
            //Get the ID hash code value
            int IDHashCode = obj.ProductID.GetHashCode();
            //Get the string HashCode Value
            //Check for null refernece exception
            int NameHashCode = obj.ProductName == null ? 0 : obj.ProductName.GetHashCode();
            return IDHashCode ^ NameHashCode;
        }
    }
}
