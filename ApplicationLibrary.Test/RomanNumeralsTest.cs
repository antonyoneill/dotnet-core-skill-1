using FluentAssertions;
using NUnit.Framework;

namespace ApplicationLibrary.Test
{
    public class RomanNumeralsTest
    {

        [TestCase(0,"")]
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4,"IV")]
        [TestCase(5,"V")]
        [TestCase(6,"VI")]
        [TestCase(7,"VII")]
        [TestCase(8,"VIII")]
        [TestCase(9,"IX")]
        [TestCase(10, "X")]
        public void ReturnNumeral(int input, string expected)
        {
            RomanNumerals.NumberToNumeral(input).Should().Be(expected);
        }
    }
}
