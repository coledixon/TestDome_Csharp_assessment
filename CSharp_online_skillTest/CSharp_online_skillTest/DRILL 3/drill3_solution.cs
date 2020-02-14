using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_online_skillTest.DRILL_3
{
    public class AnagramEval
    {
        public static List<char> stringOne = new List<char>();
        public static List<char> stringTwo = new List<char>();

        public static bool EvalAnagram(string str1, string str2)
        {
            if (str1.Length != str2.Length) { return false; }
            else {
                if (!string.IsNullOrEmpty(str1))
                {
                    stringOne = ParseStringToCharList(str1);
                }
                if (!string.IsNullOrEmpty(str2))
                {
                    stringTwo = ParseStringToCharList(str2);
                }

                stringOne.Sort();
                stringTwo.Sort();

                for(int c = 0; c < stringOne.Count; c++)
                {
                    if (stringOne[c] != stringTwo[c])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static List<char> ParseStringToCharList(string str)
        {
            Char[] chars = str.ToLower().ToCharArray();

            return chars.ToList();
        }
    }
}
