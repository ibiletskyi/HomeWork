using NUnit.Framework;
using Task8;

namespace Tests
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void Test1()
        {
            Assert.AreEqual(new Figure(0, 0).Draw(), "I'm the Figure");
            Assert.AreEqual(new Square(0, 0).Draw(), "I'm the Square");
            Assert.AreEqual(new Rectangle(0, 0).Draw(), "I'm the Rectangle");
        }
    }
}