using NUnit.Framework;

namespace FunTesting
{
    public interface IAddition
    {
        decimal Add(decimal first, decimal second);
        decimal Add(decimal first, decimal second, decimal third);
    }
    public class Addition : IAddition
    {
        public decimal Add(decimal first, decimal second) => first + second;

        public decimal Add(decimal first, decimal second, decimal third) => first + second + third;
    }

    [TestFixture]
    public class AdditionTest
    {
        private IAddition _addition = null;
        [SetUp]
        public void Setup()
        {
            _addition = new Addition();
        }

        [Test]
        public void Check_Memory_Allocated()
        {
            // Arrange // Act // Assert
            Assert.IsNotNull(_addition);
        }
        [Test]
        public void Check_Used_Type()
        {
            // Arrange // Act 
            // Assert
            Assert.IsInstanceOf(typeof(IAddition), _addition);
        }

        [Test]
        public void Validate_For_10_5()
        {
            // Arrange 
            // Act 
            var actual = this._addition.Add(10, 5);
            // Assert
            Assert.That(15, Is.EqualTo(actual));
        }

        [Test]
        public void Validate_For_10_5_5()
        {
            // Arrange 
            // Act 
            var actual = this._addition.Add(10, 5.5M);
            // Assert
            Assert.That(15.5M, Is.EqualTo(actual));
        }

        [Test]
        public void Validate_For_10_5_35()
        {
            // Arrange 
            // Act 
            var actual = this._addition.Add(10, 5, 35);
            // Assert
            Assert.That(50, Is.EqualTo(actual));
        }

        [Test]
        public void Validate_For_10_5_9_35_7()
        {
            // Arrange 
            // Act 
            var actual = this._addition.Add(10, 5.9M, 35.7M);
            // Assert
            Assert.That(51.6M, Is.EqualTo(actual));
        }
    }
}
