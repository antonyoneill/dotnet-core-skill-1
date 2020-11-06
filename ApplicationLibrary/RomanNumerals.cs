using System;

namespace ApplicationLibrary
{
    public class RomanNumerals
    {
        public static string NumberToNumeral(int number)
        {
            if (number == 5)
            {
                return "V";
            }

            if (number == 4)
            {
                return "IV";
            }

            return "".PadLeft(number, 'I');
        }
    }
}