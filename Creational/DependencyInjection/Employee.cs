using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.DependencyInjection
{
    public interface IEmployee
    {
        int Id { get; set; }
        string Name { get; set; }
        string Address { get; set; }
    }

    public class Employee : IEmployee
    {
        public int Id { get ; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }


}
