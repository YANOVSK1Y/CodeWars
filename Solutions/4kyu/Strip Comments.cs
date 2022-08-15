using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions._4kyu
{
    /// <summary>
    /// Complete the solution so that it strips 
    /// all text that follows any of a set of comment 
    /// markers passed in. Any whitespace at the end 
    /// of the line should also be stripped out. 
    /// </summary>
    public static class Strip_Comments
    {
        public static string StripComments(string text, string[] commentSymbols)
        {
            string[] st = text.Split('\n');
            var res = st.Select(item => item.Split(commentSymbols, StringSplitOptions.None).First().TrimEnd()).ToArray();
            return String.Join("\n", res);
        }
    }
}
