using System;
using NUnit.Framework;

namespace Cw5.Tests
{
    [TestFixture]
    public class DiscountFromPeselComputerTests
    {
        private IDiscountFromPeselComputer _discountFromPeselComputer;

        [SetUp]
        public void SetUp()
        {
            //Arrange:
            _discountFromPeselComputer= new DiscountFromPeselComputer();
        }

        //Discount before 18
        [Test]
        public void TestDayBefore18()
        {
            //Act:
            DateTime now = DateTime.Now;
            DateTime age18 = now.AddYears(-18);
            DateTime dayBefore18 = age18.AddDays(1);
            
            string pesel = dayBefore18.Year.ToString().Substring(2,2) + dayBefore18.Month + dayBefore18.Day + "49632";
            bool hasDiscount = _discountFromPeselComputer.HasDiscount(pesel);
            //Assert:
            Assert.True(hasDiscount);
        }
        
        [Test]
        public void TestMonthBefore18()
        {
            //Act:
            DateTime now = DateTime.Now;
            DateTime age18 = now.AddYears(-18);
            DateTime monthBefore18 = age18.AddMonths(1);
            
            string pesel = monthBefore18.Year.ToString().Substring(2,2) + monthBefore18.Month + monthBefore18.Day + "49632";
            bool hasDiscount = _discountFromPeselComputer.HasDiscount(pesel);
            //Assert:
            Assert.True(hasDiscount);
        }
        
        [Test]
        public void TestYearBefore18()
        {
            //Act:
            DateTime now = DateTime.Now;
            DateTime age18 = now.AddYears(-18);
            DateTime yearBefore18 = age18.AddYears(1);
            
            string pesel = yearBefore18.Year.ToString().Substring(2,2) + yearBefore18.Month + yearBefore18.Day + "49632";
            bool hasDiscount = _discountFromPeselComputer.HasDiscount(pesel);
            //Assert:
            Assert.True(hasDiscount);
        }
        
        //No discount between 18 and 65
        [Test]
        public void TestDayAfter18()
        {
            //Act:
            DateTime now = DateTime.Now;
            DateTime age18 = now.AddYears(-18);
            DateTime dayAfter18 = age18.AddDays(-1);
            
            string pesel = dayAfter18.Year.ToString().Substring(2,2) + dayAfter18.Month + dayAfter18.Day + "49632";
            bool hasDiscount = _discountFromPeselComputer.HasDiscount(pesel);
            //Assert:
            Assert.False(hasDiscount);
        }
        
        [Test]
        public void TestMonthAfter18()
        {
            //Act:
            DateTime now = DateTime.Now;
            DateTime age18 = now.AddYears(-18);
            DateTime monthAfter18 = age18.AddMonths(-1);
            
            string pesel = monthAfter18.Year.ToString().Substring(2,2) + monthAfter18.Month + monthAfter18.Day + "49632";
            bool hasDiscount = _discountFromPeselComputer.HasDiscount(pesel);
            //Assert:
            Assert.False(hasDiscount);
        }
        
        [Test]
        public void TestYearAfter18()
        {
            //Act:
            DateTime now = DateTime.Now;
            DateTime age18 = now.AddYears(-18);
            DateTime yearAfter18 = age18.AddYears(-1);
            
            string pesel = yearAfter18.Year.ToString().Substring(2,2) + yearAfter18.Month + yearAfter18.Day + "49632";
            bool hasDiscount = _discountFromPeselComputer.HasDiscount(pesel);
            //Assert:
            Assert.False(hasDiscount);
        }
        
        [Test]
        public void TestDayBefore65()
        {
            //Act:
            DateTime now = DateTime.Now;
            DateTime age65 = now.AddYears(-65);
            DateTime dayBefore65 = age65.AddDays(1);
            
            string pesel = dayBefore65.Year.ToString().Substring(2,2) + dayBefore65.Month + dayBefore65.Day + "49632";
            bool hasDiscount = _discountFromPeselComputer.HasDiscount(pesel);
            //Assert:
            Assert.False(hasDiscount);
        }
        
        [Test]
        public void TestMonthBefore65()
        {
            //Act:
            DateTime now = DateTime.Now;
            DateTime age65 = now.AddYears(-65);
            DateTime monthBefore65 = age65.AddMonths(1);
            
            string pesel = monthBefore65.Year.ToString().Substring(2,2) + monthBefore65.Month + monthBefore65.Day + "49632";
            bool hasDiscount = _discountFromPeselComputer.HasDiscount(pesel);
            //Assert:
            Assert.False(hasDiscount);
        }
        
        [Test]
        public void TestYearBefore65()
        {
            //Act:
            DateTime now = DateTime.Now;
            DateTime age65 = now.AddYears(-65);
            DateTime yearBefore65 = age65.AddYears(1);
            
            string pesel = yearBefore65.Year.ToString().Substring(2,2) + yearBefore65.Month + yearBefore65.Day + "49632";
            bool hasDiscount = _discountFromPeselComputer.HasDiscount(pesel);
            //Assert:
            Assert.False(hasDiscount);
        }
        
        //Discount after 65
        [Test]
        public void TestDayAfter65()
        {
            //Act:
            DateTime now = DateTime.Now;
            DateTime age65 = now.AddYears(-65);
            DateTime dayAfter65 = age65.AddDays(-1);
            
            string pesel = dayAfter65.Year.ToString().Substring(2,2) + dayAfter65.Month + dayAfter65.Day + "49632";
            bool hasDiscount = _discountFromPeselComputer.HasDiscount(pesel);
            //Assert:
            Assert.True(hasDiscount);
        }
        
        [Test]
        public void TestMonthAfter65()
        {
            //Act:
            DateTime now = DateTime.Now;
            DateTime age65 = now.AddYears(-65);
            DateTime monthAfter65 = age65.AddMonths(-1);
            
            string pesel = monthAfter65.Year.ToString().Substring(2,2) + monthAfter65.Month + monthAfter65.Day + "49632";
            bool hasDiscount = _discountFromPeselComputer.HasDiscount(pesel);
            //Assert:
            Assert.True(hasDiscount);
        }
        
        [Test]
        public void TestYearAfter65()
        {
            //Act:
            DateTime now = DateTime.Now;
            DateTime age65 = now.AddYears(-65);
            DateTime yearsAfter65 = age65.AddYears(-1);
            
            string pesel = yearsAfter65.Year.ToString().Substring(2,2) + yearsAfter65.Month + yearsAfter65.Day + "49632";
            bool hasDiscount = _discountFromPeselComputer.HasDiscount(pesel);
            //Assert:
            Assert.True(hasDiscount);
        }
        
    }
}