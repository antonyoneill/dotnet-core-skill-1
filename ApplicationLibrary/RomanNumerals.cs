using System;

namespace ApplicationLibrary
{
    public class RomanNumerals
    {
        public static string NumberToNumeral(int number)
        {
            return "".PadLeft(number, 'I');
        }
    }
}
