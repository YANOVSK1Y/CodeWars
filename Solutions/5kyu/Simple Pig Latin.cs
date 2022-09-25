using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions._5kyu
{
    public class Simple_Pig_Latin
    {
        public static string PigIt(string str)
        {
            return string.Join(" ", str.Split(" ").Select(s => Char.IsLetter(s[0]) ? s.Substring(1, s.Length - 1) + s[0] + "ay" : s));
        }
    }
}
