namespace Cw5
{
    public class StringConcatenator1
    {
        public string Concat(string a, string b)
        {
            if (a == null || b == null)
                return null;
            return a + b;
        }
    }
}