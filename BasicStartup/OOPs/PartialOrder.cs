using System;
using System.Collections.Generic;
using System.Text;

namespace BasicStartup.OOPs
{
    /**
     * We could split content of class into different physical file, but logically its single
     * To make better mainentance by compacting large classes
     * group of people working in same business logic
     * Used sections
     *  1. Asp.net auto generated code for form and code
     *  2. win forms component design
     *  3. Linq and EF
     * **/
    public partial class PartialOrder
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int Quantitiy { get; set; }
        public bool CreateOrder()
        {
            Console.WriteLine($"Order Created!");
            return true;
        }

        partial void EditOrder(int orderId);
    }
}
