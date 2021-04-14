using System;
using System.Linq.Expressions;

namespace Cw5
{
    public class StringConcatenator2
    {
        public string Concat(string a, string b)
        {
            if (a == null && b == null)
                throw new NullReferenceException("Both arguments are null");
            if (a == null)
                throw new NullReferenceException("First argument is null");
            if(b == null)
                throw new NullReferenceException("Second argument is null");
            return a + b;
        }
    }
}