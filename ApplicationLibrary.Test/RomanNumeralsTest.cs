using FluentAssertions;
using NUnit.Framework;

namespace ApplicationLibrary.Test
{
    public class RomanNumeralsTest
    {

        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4,"IV")]
        [TestCase(5,"V")]
        public void ReturnNumeral(int input, string expected)
        {
            RomanNumerals.NumberToNumeral(input).Should().Be(expected);
        }
    }
}
