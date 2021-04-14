using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Cw5
{
    public interface IAnagramChecker
    {
        bool IsAnagram(string word1, string word2);
    }
    
    public class AnagramChecker : IAnagramChecker
    {
        public bool IsAnagram(string word1, string word2)
        {
            if(word1 == null || word2 == null)
                throw new NullReferenceException("Null word");
            
            Regex rgx = new Regex("[^a-zA-Z0-9]");
            word1 = rgx.Replace(word1, "");
            word2 = rgx.Replace(word2, "");

            word1 = word1.ToLower();
            word2 = word2.ToLower();

            word1 = string.Concat(word1.OrderBy(c => c));
            word2 = string.Concat(word2.OrderBy(c => c));

            return word1.Equals(word2);
        }
    }
}