namespace BasicStartup.OOPs
{
    public partial class PartialOrder
    {
        partial void EditOrder(int orderId)
        {
            var editOrder = new { id = this.OrderId, CustomerId = CustomerId };
            System.Console.WriteLine($"Order Edited!");
        }
    }
}
