using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeapYear;

namespace LeapYear.Tests
{
  [TestClass]
  public class LeapYearTest
  {
    [TestMethod]
    public void IsLeapYear_NumberDivisibleByFour_True()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(true, testLeapYear.IsLeapYear(2012));
    }
    [TestMethod]
    public void IsLeapYear_NumberNotDivisibleByFour_False()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(false, testLeapYear.IsLeapYear(1990));
    }
    [TestMethod]
    public void IsLeapYear_NumberDivisibleByOneHundred_False()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(false, testLeapYear.IsLeapYear(1900));
    }
    [TestMethod]
    public void IsLeapYear_NumberDivisibleByFourHundred_True()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(true, testLeapYear.IsLeapYear(2000));
    }
  }
}
