using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    public abstract class OrderBase
    {
        protected IList<Product> products = new List<Product>() {
            new Product {Name = "Phone", Price = 587},
            new Product {Name = "Tablet", Price = 800},
            new Product {Name = "PC", Price = 1200}
        };
        public abstract double CalculatetotalOrderPrice();
    }

    public class RegularOrder : OrderBase
    {
        public override double CalculatetotalOrderPrice() => products.Sum(x => x.Price);
    }

    public class PreOrder : OrderBase
    {
        public override double CalculatetotalOrderPrice() => products.Sum(x => x.Price) * 0.05;
    }

    public class OrderDecorator : OrderBase
    {
        protected OrderBase order;
        public OrderDecorator(OrderBase orderBase)
        {
            order = orderBase;
        }
        public override double CalculatetotalOrderPrice() => order.CalculatetotalOrderPrice();
    }

    public class PremiumPreOrder : OrderDecorator
    {
        public PremiumPreOrder(OrderBase order):base(order)
        {

        }
        public override double CalculatetotalOrderPrice()
        {
            var preOrderPrice = base.CalculatetotalOrderPrice();
            return preOrderPrice * 0.9;
        }
    }
}
