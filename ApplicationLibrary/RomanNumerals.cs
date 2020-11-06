using System;

namespace ApplicationLibrary
{
    public static class RomanNumerals
    {
        private static string V = "V";
        private static string I = "I";
        
        public static string NumberToNumeral(int number)
        {
            if (number > 5)
            {
                return V + "".PadLeft(number - 5, I.ToCharArray()[0]);
            }
            if (number == 5)
            {
                return V;
            }

            if (number == 4)
            {
                return I + V;
            }

            return "".PadLeft(number, I.ToCharArray()[0]);
        }
    }
}