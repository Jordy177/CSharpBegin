using System;

namespace Acme.Common
{
    public static class StringHandler
    {
        public static string ReturnCleanString(this string fileString)
        {
            string result = string.Empty;

            foreach (char letter in fileString)
            {
                if (letter == char.ToUpper(letter))
                {
                    result += " ";
                }

                result += letter;
            }

            return result.Trim();
        }
    }
}
