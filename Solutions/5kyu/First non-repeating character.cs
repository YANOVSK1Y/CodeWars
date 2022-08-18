using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Solutions._5kyu
{
    /// <summary>
    /// Write a function named first_non_repeating_letter that takes a string input, and returns the first character that is not repeated anywhere in the string.
    //    For example, if given the input 'stress', the function should return 't', since the letter t only occurs once in the string, and occurs first in the string.
    //As an added challenge, upper- and lowercase letters are considered the same character, but the function should return the correct case for the initial letter.For example, the input 'sTreSS' should return 'T'.
    //If a string contains all repeating characters, it should return an empty string ("") or None -- see sample tests.

    /// </summary>
    public class First_non_repeating_character
    {
        public static string FirstNonRepeatingLetter(string s)
        {
            return s.GroupBy(char.ToLower)
            .Where(gr => gr.Count() == 1)
            .Select(x => x.First().ToString())
            .DefaultIfEmpty("")
            .First();
        }
    }
}
