using NUnit.Framework;
using Task6;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestDrawReturnsPropertly()
        {            
            Assert.AreEqual(new Square().Draw(), "Square");
            Assert.AreEqual(new Rectangle().Draw(), "Rectangle");
        }
    }
}