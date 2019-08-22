using LinqProcess.Quantifier;
using NUnit.Framework;
using System;

namespace LinqProcessTest.Quantifier
{
    [TestFixture]
    public class AnyExcerciseTest
    {
        private IAnyExcercise _anyExcercise = null;
        [SetUp]
        public void Initilize()
        {
            _anyExcercise = new AnyExcercise();
        }
        [Test]
        public void Check_AnyExcercise_Got_Memory()
        {
            // Arrange // Act // Assert
            Assert.IsNotNull(_anyExcercise);
        }
        [Test]
        public void Check_The_Object_Type()
        {
            // Arrange // Act // Assert
            Assert.IsInstanceOf(typeof(AnyExcercise), _anyExcercise);
        }

        [Test]
        public void Check_The_Method_Return_for_Null()
        {
            // Arrange // Act // Assert
            Assert.AreEqual(false, _anyExcercise.CheckAnyItems(new int[] { }));
        }
        [Test]
        public void Check_The_Method_For_Empty()
        {
            var actual = _anyExcercise.CheckAnyItems(new int[] { });
            Assert.AreEqual(false, actual);
        }
        [Test]
        public void Check_The_Method_Return_True()
        {
            var actual = _anyExcercise.CheckAnyItems(new int[] { 10 });
            Assert.AreEqual(true, actual);
        }

        [Test]
        public void Check_The_Method_for_45()
        {
            var actual = _anyExcercise.CheckAnyItems(new int[] { 10, 55, 67, 89, 34, 45, 66, 89 }, 45);
            Assert.AreEqual(true, actual);
        }

        [Test]
        public void Check_The_Method_for_55()
        {
            var actual = _anyExcercise.CheckAnyItems(new int[] { 10, 67, 89, 34, 45, 66, 89 }, 55);
            Assert.AreEqual(false, actual);
        }

        [Test]
        public void Check_The_Method_for_Greater_AnyFail()
        {            
            Func<int, bool> _isGreater = (int x) => x < 45;
            var actual = _anyExcercise.CheckAnyItems(new int[] { 10, 67, 89, 34, 45, 66, 89 }, _isGreater);
            Assert.AreEqual(true, actual);
        }

        [Test]
        public void Check_The_Method_for_Greater_AnyPass()
        {
            Func<int, bool> _isGreater = (int x) => x > 45;
            var actual = _anyExcercise.CheckAnyItems(new int[] { 10, 67, 89, 34, 45, 66, 89 }, _isGreater);
            Assert.AreEqual(true, actual);
        }
    }
}
