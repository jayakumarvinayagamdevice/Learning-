using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.DependencyInjection
{
    public interface IPropertyGetEmployeeBL
    {
        IReadOnlyCollection<IEmployee> Get();
        IConstructorGetEmployeeDL ConstructorGetEmployeeDL { get; set; }
    }

    public class PropertyGetEmployeeBL : IPropertyGetEmployeeBL
    {
        private IConstructorGetEmployeeDL _constructorGetEmployeeDL = null;
        public IConstructorGetEmployeeDL ConstructorGetEmployeeDL {
            get {
                if (ConstructorGetEmployeeDL == null)
                    throw new Exception("memory not initilized");
                else
                {
                    return _constructorGetEmployeeDL;
                }
            }
            set {
                this._constructorGetEmployeeDL = value;
            } }

        public IReadOnlyCollection<IEmployee> Get()
        {
            return this._constructorGetEmployeeDL.GetAllEmployee();
        }
    }
}
