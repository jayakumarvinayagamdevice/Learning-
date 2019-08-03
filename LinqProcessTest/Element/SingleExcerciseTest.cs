using LinqProcess.Element;
using NUnit.Framework;
using System;

namespace LinqProcessTest.Element
{
    [TestFixture]
    public class SingleExcerciseTest
    {
        private int[] mathMarks = null;
        private ISingleExcercise _singleExcercise = null;
        [SetUp]
        public void Initilize()
        {
            mathMarks = new int[] { 34, 56, 78, 98, 65, 45, 34, 22, 99, 56
                                    , 89, 34, 78, 88, 94 };
            _singleExcercise = new SingleExcercise();
        }

        [Test]
        public void Check_SingleExcercise_Got_Memory()
        {
            // Arrange // Act // Assert
            Assert.IsNotNull(_singleExcercise);
        }
        [Test]
        public void Check_The_Object_Type()
        {
            // Arrange // Act // Assert
            Assert.IsInstanceOf(typeof(SingleExcercise), _singleExcercise);
        }

        [Test]
        public void Check_The_Method_Return_Exception_for_Null()
        {
            // Arrange // Act // Assert
            Assert.Throws<InvalidOperationException>(() => _singleExcercise.SearchFirstMark(new int[] { }));
        }

        [Test]
        public void Check_The_Method_Return_Exception_for_MoreThenOne()
        {
            // Arrange // Act // Assert
            Assert.Throws<InvalidOperationException>(() => _singleExcercise.SearchFirstMark(mathMarks));
        }

        [Test]
        public void Check_The_Method_Return_10()
        {
            // Arrange // Act // Assert
            var actual = _singleExcercise.SearchFirstMark(new int[] { 10});
            Assert.AreEqual(10, actual);
        }

        [Test]
        public void Check_The_Method_Return_For_Condition()
        {
            // Arrange // Act // Assert
            var actual = _singleExcercise.SearchTopMark(mathMarks, 98);
            Assert.AreEqual(99, actual);
        }

        [Test]
        public void Check_The_Method_Return_For_Predicate()
        {
            // Arrange // Act // Assert   
            Func<int, bool> isGreater =
            (int x) => x > 98;
            var actual = _singleExcercise.SearchTopMark(mathMarks, isGreater);
            Assert.AreEqual(99, actual);
        }
    }
}