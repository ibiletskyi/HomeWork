using NUnit.Framework;
using Task9;

namespace Tests
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void Test1()
        {
            Assert.AreEqual(new Figure().Draw(), "I'm the Figure");
            Assert.AreEqual(new Square().Draw(), "I'm the Square");
            Assert.AreEqual(new Rectangle().Draw(), "I'm the Rectangle");
        }
    }
}