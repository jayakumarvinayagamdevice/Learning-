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
    public class ConstructorGetEmployeeBLTest
    {
        private Mock<IConstructorGetEmployeeDL> _repository;
        private IConstructorGetEmployeeBL _constructorGetEmployeeBL;
        [SetUp]
        public void TestSetUp()
        {
            IList<IEmployee> _employee = new List<IEmployee>() {
                new Employee{ Id = 1001, Address = "Chennai", Name="Jayakumar Vinayagam" }
            };
            var _testableEmployee = new ReadOnlyCollection<IEmployee>(_employee);
            _repository = new Mock<IConstructorGetEmployeeDL>(MockBehavior.Strict);
            _repository.Setup(r => r.GetAllEmployee()).Returns(_testableEmployee);

            _constructorGetEmployeeBL = new ConstructorGetEmployeeBL(_repository.Object);
        }

        [Test]
        public void CheckMemoryAllocated()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsNotNull(_constructorGetEmployeeBL);
        }

        [Test]
        public void CheckType()
        {
            //Arrange
            //Act
            //Assert           
            Assert.IsInstanceOf(typeof(IConstructorGetEmployeeBL), _constructorGetEmployeeBL);
        }
        [Test]
        public void CheckRowCount()
        {
            //Arrange
            //Act
            var actual = _constructorGetEmployeeBL.Get();
            //Assert           
            Assert.IsTrue(actual.Count()>=1);
        }

        [Test]
        public void CheckUserName()
        {
            //Arrange
            //Act
            var actual = _constructorGetEmployeeBL.Get();
            //Assert           
            Assert.AreEqual("Jayakumar Vinayagam", actual.FirstOrDefault().Name, "error message");
        }
    }
}
