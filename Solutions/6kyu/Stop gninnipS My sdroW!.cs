using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; 

namespace Solutions._6kyu
{

    /// <summary>
    /// Write a function that takes in a string of one or more words,
    /// and returns the same string, but with all five or more 
    /// letter words reversed (Just like the name of this Kata). 
    /// Strings passed in will consist of only letters and spaces. 
    /// Spaces will be included only when more than one word is present.
    /// </summary>
    public class Kata
    {
        public static string ReverseString(string myStr)
        {
            char[] myArr = myStr.ToCharArray();
            Array.Reverse(myArr);
            return new string(myArr);
        }
        public static string SpinWords(string sentence)
        {
            var lst = sentence.Split(" ");
            ArrayList words = new ArrayList();
            foreach(var item in lst)
            {
                if (item.Length >= 5)
                {
                    words.Add(ReverseString(item)); 
                }
                else
                {
                    words.Add(item);
                }
            }
            return String.Join(" ", (string[])words.ToArray(typeof(string))); 
        }
    }
}
