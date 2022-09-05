using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions._5kyu
{
    public class Convert_PascalCase_string_into_snake_case
    {
        public static string ToUnderscore(int str)
        {
            return str.ToString();
        }

        public static string ToUnderscore(string str)
        {
            String res = String.Empty;

            foreach(var item in str)
            {
                if (Char.IsLetter(item) && Char.IsUpper(item))
                {
                    if (res.Length != 0) res += "_" + Char.ToLower(item);
                    else res += Char.ToLower(item);
                }
                else
                {
                    res += item;
                }
            }
            return res;
        }
    }
}
