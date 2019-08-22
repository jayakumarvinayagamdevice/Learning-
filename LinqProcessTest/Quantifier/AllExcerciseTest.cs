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
    public class AllExcerciseTest
    {
        private int[] mathMarks = null;
        private IAllExcercise _allExcercise = null;
        [SetUp]
        public void Initilize()
        {
            mathMarks = new int[] { 34, 56, 78, 98, 65, 45, 34, 22, 99, 56
                                    , 89, 34, 78, 88, 94 };
            _allExcercise = new AllExcercise();
        }

        [Test]
        public void Check_AllExcercise_Got_Memory()
        {
            // Arrange // Act // Assert
            Assert.IsNotNull(_allExcercise);
        }
        [Test]
        public void Check_The_Object_Type()
        {
            // Arrange // Act // Assert
            Assert.IsInstanceOf(typeof(AllExcercise), _allExcercise);
        }

        [Test]
        public void Check_The_Method_Return_Exception_for_Null()
        {
            // Arrange // Act // Assert
            Assert.Throws<InvalidOperationException>(() => _allExcercise.CheckAllItems(new int[] { }));
        }

        [Test]
        public void Check_The_Method_Return_True_For_Above_30()
        {
            // Arrange // Act // Assert
            var actual = _allExcercise.CheckAllItems(new int[] { 55, 56, 70, 35 });
            Assert.AreEqual(true, actual);
        }

        [Test]
        public void Check_The_Method_Return_False_For_Above_30()
        {
            // Arrange // Act // Assert
            var actual = _allExcercise.CheckAllItems(new int[] { 55, 56, 70, 35, 25 });
            Assert.AreEqual(false, actual);
        }

        [Test]
        public void Check_The_Method_Return_True_For_Above_50()
        {
            // Arrange // Act // Assert
            var actual = _allExcercise.CheckAllItems(new int[] { 55, 56, 70, 95 }, 50);
            Assert.AreEqual(true, actual);
        }

        [Test]
        public void Check_The_Method_Return_True_For_Above_35()
        {
            // Arrange // Act // Assert
            Func<int, bool> isGreater = (int x) => x > 35;
            var actual = _allExcercise.CheckAllItems(new int[] { 55, 56, 70, 45 }, isGreater);
            Assert.AreEqual(true, actual);
        }
    }
}
