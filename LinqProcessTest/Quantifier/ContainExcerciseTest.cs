using LinqProcess.Quantifier;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProcessTest.Quantifier
{
    [TestFixture]
    public class ContainExcerciseTest
    {
        private IContainExcercise _containExcercise = null;
        [SetUp]
        public void Initilize()
        {
            _containExcercise = new ContainExcercise();
        }
        [Test]
        public void Check_AnyExcercise_Got_Memory()
        {
            // Arrange // Act // Assert
            Assert.IsNotNull(_containExcercise);
        }
        [Test]
        public void Check_The_Object_Type()
        {
            // Arrange // Act // Assert
            Assert.IsInstanceOf(typeof(ContainExcercise), _containExcercise);
        }

        [Test]
        public void Check_The_Method_Return_for_Null()
        {
            // Arrange // Act // Assert
            Assert.AreEqual(false, _containExcercise.CheckAllItems(new int[] {}));
        }

        [Test]
        public void Check_The_Method_Return_false_45()
        {
            // Arrange // Act // Assert
            Assert.AreEqual(false, _containExcercise.CheckAllItems(new int[] { 54, 67, 77, 89, 01 }));            
        }

        [Test]
        public void Check_The_Method_Return_True_45()
        {
            // Arrange // Act // Assert
            Assert.AreEqual(true, _containExcercise.CheckAllItems(new int[] { 54, 67, 77, 45, 89, 01 }));
        }

        [Test]
        public void Check_The_Method_Return_True_75()
        {
            // Arrange // Act // Assert
            Assert.AreEqual(true, _containExcercise.CheckAllItems(new int[] { 54, 67, 75, 45, 89, 01 }, 75));
        }
    }
}
