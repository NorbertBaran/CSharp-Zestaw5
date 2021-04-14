using System;

namespace Cw5
{
    public interface IDiscountFromPeselComputer
    {
        bool HasDiscount(string pesel);
    }

    public class InvalidPeselException : Exception
    {
        public InvalidPeselException(string message) : base(message) { }
    }
    
    public class DiscountFromPeselComputer : IDiscountFromPeselComputer
    {
        public bool HasDiscount(string pesel)
        {
            try
            {
                DateTime now = DateTime.Now;
                DateTime before18 = now.AddYears(-18);
                DateTime before65 = now.AddYears(-65);
                            
                int year = Int32.Parse(pesel.Substring(0, 2));
                int Month = Int32.Parse(pesel.Substring(2, 2));
                int day = Int32.Parse(pesel.Substring(4, 2));
                DateTime birthDate = new DateTime(DateTime.Now.Year - year > 2000 ? 2000 + year : 1900 + year, Month, day);
                
                if (birthDate > before18 || birthDate < before65)
                    return true;
                return false;
            }
            catch (Exception e)
            {
                throw new InvalidPeselException(e.Message);
            }
        }
    }
}