using System;
using NUnit.Framework;

namespace Cw5.Tests
{
    [TestFixture]
    public class StringConcatenator2Tests
    {
        private StringConcatenator2 _stringConcatenator2;

        [SetUp]
        public void SetUp()
        {
            //Arrange:
            _stringConcatenator2 = new StringConcatenator2();
        }
        
        [Test]
        public void TestStringConcatenatorWithFirstStringNull()
        {
            //Assert:
            Assert.Throws<NullReferenceException>(
                () => _stringConcatenator2.Concat(null, "Not null")
                );
        }
        
        [Test]
        public void TestStringConcatenatorWithSecondStringNull()
        {
            //Assert:
            Assert.Throws<NullReferenceException>(
                () => _stringConcatenator2.Concat( "Not null", null)
            );
        }
        
        [Test]
        public void TestStringConcatenatorWithBothStringNull()
        {
            //Assert:
            Assert.Throws<NullReferenceException>(
                () => _stringConcatenator2.Concat(null, null)
            );
        }
        
        [Test]
        public void TestStringConcatenatorWithoutNull()
        {
            //Act:
            string result = _stringConcatenator2.Concat("Not null 1 + ", "Not null 2");
            
            //Assert:
            Assert.AreEqual("Not null 1 + Not null 2", result);
        }
    }
}