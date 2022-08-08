using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; 

namespace Solutions._6kyu
{
    public static class WeIrD_StRiNg_CaSe
    {
        /// <summary>
        /// Write a function toWeirdCase (weirdcase in Ruby) that 
        /// accepts a string, and returns the same string with all 
        /// even indexed characters in each word upper cased, and 
        /// all odd indexed characters in each word lower cased. 
        /// The indexing just explained is zero based, so the 
        /// zero-ith index is even, therefore that character should 
        /// be upper cased and you need to start over for each word.
        ///
        ///The passed in string will only consist of alphabetical 
        ///characters and spaces(' '). Spaces will only be present
        ///if there are multiple words.Words will be separated by a single space(' ').
        /// </summary>
        public static string ToWeirdCase(string s)
        {
            var words = s.Split(' ');
            ArrayList res = new ArrayList(); 
            foreach (var item in words)
            {
                string word = string.Empty; 
                for (int i = 0; i < item.Length; i++)
                {
                    if (i % 2 == 0) word += char.ToUpper(item[i]);
                    else word += char.ToLower(item[i]); 
                }
                res.Add(word); 
            }
            
            return string.Join(" ", res.ToArray()); 
        }
    }
}
