using LinqProcess.Sort;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace LinqProcessTest.Sort
{
    [TestFixture]
    public class OrderByExcerciseTest
    {
        private IOrderByExcercise _orderByExcercise = null;
        private IList<Student> _students = new List<Student>() {
            new Student() { Id = 1, Name = "John", Age = 18 } ,
            new Student() { Id = 2, Name = "Steve",  Age = 15 } ,
            new Student() { Id = 3, Name = "Bill",  Age = 25 } ,
            new Student() { Id = 4, Name = "Ram" , Age = 20 } ,
            new Student() { Id = 5, Name = "Ron" , Age = 19 }
        };
        [SetUp]
        public void Initilize()        {

            _orderByExcercise = new OrderByExcercise();
        }

        [Test]
        public void Check_AllExcercise_Got_Memory()
        {
            // Arrange // Act // Assert
            Assert.IsNotNull(_orderByExcercise);
        }
        [Test]
        public void Check_The_Object_Type()
        {
            // Arrange // Act // Assert
            Assert.IsInstanceOf(typeof(OrderByExcercise), _orderByExcercise);
        }

        [Test]
        public void Check_The_Method_for_Null()
        {
            // Arrange // Act // Assert
            Assert.IsNotNull(_orderByExcercise.SortOrder(new string[] { "India", "China", "Newzland", "Japan" }));
        }

        [Test]
        public void Check_The_Method_for_Null_excepton()
        {
            // Arrange // Act // Assert            
            Assert.IsNotNull(_orderByExcercise.SortOrder(_students));
        }

        [Test]
        public void Check_The_Method_for_Generic_Null()
        {
            
            Func<Student, string> _isGreater = (Student x) => x.Name;
            // Arrange // Act // Assert            
            Assert.IsNotNull(_orderByExcercise.SortOrder(_students, _isGreater));
        }

        [Test]
        public void Check_The_Method_Student()
        {
            Func<Student, string> _isGreater = (Student x) => x.Name;
            // Arrange // Act // Assert            
            var students = _orderByExcercise.SortOrder(_students, _isGreater);
            Assert.AreEqual(5, students.Count());
        }

    }
}
