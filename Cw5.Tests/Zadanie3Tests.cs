using System;
using NUnit.Framework;

namespace Cw5.Tests
{
    [TestFixture]
    public class AnagramCheckerTest
    {
        private IAnagramChecker _anagramChecker;
        
        [SetUp]
        public void SetUp()
        {
            //Arrange:
            _anagramChecker = new AnagramChecker();
        }

        [Test]
        public void TestAreNotAnagrams()
        {
            //Act:
            string word1 = "AbC";
            string word2 = "AbD";
            bool isAnagram = _anagramChecker.IsAnagram(word1, word2);
            //Assert:
            Assert.False(isAnagram);
        }

        [Test]
        public void TestAreAnagrams()
        {
            //Act:
            string word1 = "AbCab";
            string word2 = "CAbab";
            bool isAnagram = _anagramChecker.IsAnagram(word1, word2);
            //Assert:
            Assert.True(isAnagram);
        }

        [Test]
        public void TestAreAnagramsAfterIgnoringNotAlnum()
        {
            //Act:
            string word1 = "a+b--AC/b7+";
            string word2 = "C7A.bab*";
            bool isAnagram = _anagramChecker.IsAnagram(word1, word2);
            //Assert:
            Assert.True(isAnagram);
        }
        
        [Test]
        public void TestAreAnagramsWithDifferentSizeLetter()
        {
            //Act:
            string word1 = "abCaBCadasd";
            string word2 = "ADsCAbabDCa";
            bool isAnagram = _anagramChecker.IsAnagram(word1, word2);
            //Assert:
            Assert.True(isAnagram);
        }
        
        [Test]
        public void TestWithNullWord()
        {
            Assert.Throws<NullReferenceException>(
                () => _anagramChecker.IsAnagram("AsDf", null)
            );
        }
        
    }
}