using Creational.DependencyInjection;
using Moq;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.DependencyInjection
{
    [TestFixture]
    public class PropertyGetEmployeeBLTest
    {
        private Mock<IConstructorGetEmployeeDL> _repository;
        private IPropertyGetEmployeeBL _propertyGetEmployee = null;
        [SetUp]
        public void SetUp()
        {
            IList<IEmployee> _employee = new List<IEmployee>() {
                new Employee{ Id = 1001, Address = "Chennai", Name="Jayakumar Vinayagam" }
            };
            var _testableEmployee = new ReadOnlyCollection<IEmployee>(_employee);
            _repository = new Mock<IConstructorGetEmployeeDL>(MockBehavior.Strict);
            _repository.Setup(r => r.GetAllEmployee()).Returns(_testableEmployee);

            _propertyGetEmployee = new PropertyGetEmployeeBL(_repository.Object);
        }

        [Test]
        public void TestMethod()
        {
            // TODO: Add your test code here
            var answer = 42;
            Assert.That(answer, Is.EqualTo(42), "Some useful error message");
        }
    }
}
