using NUnit.Framework;

namespace NUnitTestProject
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

            var x = 1;
            
            Assert.Equals(1, x);
        }
    }
}