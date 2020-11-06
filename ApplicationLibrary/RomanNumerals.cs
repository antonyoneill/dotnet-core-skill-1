using System;

namespace ApplicationLibrary
{
    public static class RomanNumerals
    {
        public static string NumberToNumeral(int number)
        {
            if (number > 5)
            {
                return "V" + "".PadLeft(number - 5, 'I');
            }
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