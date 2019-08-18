using NUnit.Framework;
using Task5;

namespace Tests
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void TestMultiplyComplexNumber()
        {
            var c1 = new ComplexNumber(7, -4);
            var c2 = new ComplexNumber(3, 2);
            var multiplication = c1 * c2;

            Assert.AreEqual(multiplication, new ComplexNumber(29, 2));
        }

        [Test]
        public void TestDivideComplexNumber()
        {
            var c1 = new ComplexNumber(7, -4);
            var c2 = new ComplexNumber(3, 2);
            var division = c1 / c2;

            Assert.AreEqual(division, new ComplexNumber(1, -2));
        }
    }
}