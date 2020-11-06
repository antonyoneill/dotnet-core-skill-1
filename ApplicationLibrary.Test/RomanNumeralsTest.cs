using NUnit.Framework;
using ApplicationLibrary;
using FluentAssertions;

namespace ApplicationLibrary.Test
{
    public class RomanNumeralsTest
    {

        [Test]
        public void ReturnNumeralForOne()
        {
            RomanNumerals.NumberToNumeral(1).Should().Be("I");
        }
    }
}