
using NUnit.Framework;
using CalcLibrary;

namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calc;

        [SetUp]
        public void Init()
        {
            _calc = new Calculator();
        }

        [TearDown]
        public void Cleanup()
        {
            _calc = null;
        }

        [Test]
        [TestCase(2, 3, 5)]
        [TestCase(10, 20, 30)]
        [TestCase(-1, 1, 0)]
        public void TestAddition(int a, int b, int expected)
        {
            int result = _calc.Add(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
