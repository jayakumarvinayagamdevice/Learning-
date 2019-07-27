using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Creational.DependencyInjection
{
    public interface IConstructorGetEmployeeBL
    {
        IReadOnlyCollection<IEmployee> Get();
    }
    public class ConstructorGetEmployeeBL : IConstructorGetEmployeeBL
    {
        // Problem
        public IReadOnlyCollection<IEmployee> GetAll()
        {
            
            ConstructorGetEmployeeDL constructorGetEmployeeDL = new ConstructorGetEmployeeDL();
            // It dependent on constructorGetEmployeeDL object
            var _allEmployee = constructorGetEmployeeDL.GetAllEmployee();
            return _allEmployee;
        }

        // solution by constructor injection
        private readonly IConstructorGetEmployeeDL _constructorGetEmployeeDL = null;
        public ConstructorGetEmployeeBL(IConstructorGetEmployeeDL constructorGetEmployeeDL)
        {
            _constructorGetEmployeeDL = constructorGetEmployeeDL;
        }
        // Problem
        public IReadOnlyCollection<IEmployee> Get()
        {
            var _allEmployee = _constructorGetEmployeeDL.GetAllEmployee();
            return _allEmployee;
        }
    }
}
