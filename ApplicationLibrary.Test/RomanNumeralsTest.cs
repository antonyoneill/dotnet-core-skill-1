using FluentAssertions;
using NUnit.Framework;

namespace ApplicationLibrary.Test
{
    public class RomanNumeralsTest
    {

        [Test]
        public void ReturnNumeralForOne()
        {
            RomanNumerals.NumberToNumeral(1).Should().Be("I");
        }

        [Test]
        public void ReturnNumeralForTwo()
        {
            RomanNumerals.NumberToNumeral(2).Should().Be("II");
        }

        [Test]
        public void ReturnNumeralForThree()
        {
            RomanNumerals.NumberToNumeral(3).Should().Be("III");
        }
    }
}
