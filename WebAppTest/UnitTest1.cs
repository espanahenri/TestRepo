using NUnit.Framework;

namespace WebAppTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(1, 1);
        }
    }
}