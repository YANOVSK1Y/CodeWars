using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions._5kyu
{
    public class ROT13
    {
        public static string Rot13(string input)
        {
            return string.Concat(input.Select(c => char.IsLetter(c) ? (char)((int)c + (char.ToLower(c) <= 'm' ? 13 : -13)) : c));
        }

    }
}
