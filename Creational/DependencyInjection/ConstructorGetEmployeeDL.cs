using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Creational.DependencyInjection
{
    public interface IConstructorGetEmployeeDL
    {
        IReadOnlyCollection<IEmployee> GetAllEmployee();
    }
    class ConstructorGetEmployeeDL : IConstructorGetEmployeeDL
    {
        public IReadOnlyCollection<IEmployee> GetAllEmployee()
        {
            IList<IEmployee> _employee = new List<IEmployee>() {
                new Employee{ Id = 1001, Address = "Chennai", Name="Jayakumar Vinayagam" }
            };
            return new ReadOnlyCollection<IEmployee>(_employee);
        }
    }
}
