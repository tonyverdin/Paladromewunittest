using System;

namespace Palandrome
{
   public class Palandrome
    {

        public static bool TestPalandrome(string a)
        {
           string swapstring = a.Replace(" ", "");

           string retstring= swapstring.ToLower();

            for (int i = 0; i < retstring.Length / 2; i++)
            {
                if (retstring[i] != retstring[retstring.Length - i - 1])
                {
                    return false;
                }

            }
            return true;
        }
    }
}
