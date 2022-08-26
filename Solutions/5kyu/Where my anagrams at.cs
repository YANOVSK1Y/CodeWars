using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions._5kyu
{
    public static class Where_my_anagrams_at
    {
        public static List<string> Anagrams(string word, List<string> words)
        {
            return words?.Where(w => w.OrderBy(c => c).SequenceEqual(word.OrderBy(c => c))).ToList();
        }
    }
}
