using LinqProcess.Set;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace LinqProcessTest.Set
{
    [TestFixture]
    public class DistinctExcerciseTest
    {
        private IDistinctExcercise _distinctExcercise = null;
        private Mock<IDistinctExcercise> _distinctrepo = null;
        [SetUp]
        public void Setup()
        {
            var returnSetup = new List<int>()
            {
                1,2,3
            };
            _distinctExcercise = new DistinctExcercise();
            _distinctrepo = new Mock<IDistinctExcercise>(MockBehavior.Strict);
            _distinctrepo.Setup(r => r.Validate()).Returns(returnSetup);
        }

        [Test]
        public void CheckMemory_Allocated()
        {
            Assert.IsNotNull(_distinctExcercise);
        }

        [Test]
        public void CheckDataType()
        {
            Assert.IsInstanceOf(typeof(IDistinctExcercise), _distinctExcercise);
        }

        [Test]
        public void CheckLength()
        {
            var actual = _distinctExcercise.Validate();
            Assert.That(6, Is.EqualTo(actual.Count), "error!");
        }

        [Test]
        public void Validate_Correct_Answer()
        {            
            var actual = _distinctExcercise.Validate();
            var expected = new List<int>()
            {
                1,2,3,4,5,6
            };
            Assert.That(expected, Is.EqualTo(actual), "error!");
        }

        [Test]
        public void ValidateTheMocksetup()
        {
            // Arrange
           
        }
    }
}
