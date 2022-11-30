using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelLite
{
    internal class Converter
    {
        private static int NUMLETTERS = 26;
        public static string ConvertToLongString(int i)
        {
            //illicit value
            if (i < 1)
            {
                return "";
            }

            string result = "";
            string reversedResult = "";


            while (i > 0)
            {
                int lastletter = i % (NUMLETTERS);

                //z-case
                if (lastletter == 0)
                {
                    lastletter = 26;
                }
                //convert
                string letter = ConvertToLetter(lastletter);
                
                
                if (i > NUMLETTERS)
                {
                    //(A-Z)Z case
                    if ((i % 26) == 0)
                    {
                        i /= (NUMLETTERS + 1);
                    }

                    else
                    {
                        i /= (NUMLETTERS);
                    }
                }
                else
                {
                    i /= (NUMLETTERS + 1);
                }
                reversedResult += letter;
            }
            result = Reverse(reversedResult);
            return result;
        }
        public static string ConvertToLetter(int i)
        {
            if (i > NUMLETTERS || i == 0)
            {
                return "";
            }
            char result = (char) (i + 64);
            return result.ToString();
        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static List<string> SplitRow(string row)
        {
            List<string> result = new List<string>();
            var formulas = row.Split('@');
            foreach (string s in formulas)
            {
                result.Add(s);
            }
            return result;
        }
    }
}
