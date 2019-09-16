using System;

namespace Decorator
{
    public class DecoratorStartUp
    {
        public void Start()
        {
            Console.WriteLine("Decorator!");
            var regularOrder = new RegularOrder();
            Console.WriteLine( $"Regular-Order Total:{regularOrder.CalculatetotalOrderPrice()}" );

            var preOrder = new PreOrder();
            Console.WriteLine($"Pre-Order Total:{preOrder.CalculatetotalOrderPrice()}");

            var premiumOrder = new PremiumPreOrder(preOrder);
            Console.WriteLine($"Premium Pre-Order: {premiumOrder.CalculatetotalOrderPrice()}");
        }
    }
}
