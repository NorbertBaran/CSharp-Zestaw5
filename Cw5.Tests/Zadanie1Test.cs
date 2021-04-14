using NUnit.Framework;

namespace Cw5.Tests
{
    [TestFixture]
    public class StringConcatenator1Tests
    {
        private StringConcatenator1 _stringConcatenator1;

        [SetUp]
        public void SetUp()
        {
            //Arrange:
            _stringConcatenator1 = new StringConcatenator1();
        }
        
        [Test]
        public void TestStringConcatenatorWithFirstStringNull()
        {
            //Act:
            string result = _stringConcatenator1.Concat(null, "Not null");
            
            //Assert:
            Assert.IsNull(result);
        }
        
        [Test]
        public void TestStringConcatenatorWithSecondStringNull()
        {
            //Act:
            string result = _stringConcatenator1.Concat("Not null", null);
            
            //Assert:
            Assert.IsNull(result);
        }
        
        [Test]
        public void TestStringConcatenatorWithBothStringNull()
        {
            //Act:
            string result = _stringConcatenator1.Concat(null, null);
            
            //Assert:
            Assert.IsNull(result);
        }
        
        [Test]
        public void TestStringConcatenatorWithoutNull()
        {
            //Act:
            string result = _stringConcatenator1.Concat("Not null 1 + ", "Not null 2");
            
            //Assert:
            Assert.AreEqual("Not null 1 + Not null 2", result);
        }
    }
}