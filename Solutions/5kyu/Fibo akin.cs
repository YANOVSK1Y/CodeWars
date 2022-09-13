using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions._5kyu
{
    public class Fibo_akin
    {
        public static long LengthSupUK(int n, int k)
        {
            return Sequence(n).Count(x => x >= k);
        }

        public static long Comp(int n)
        {
            var seq = Sequence(n);
            return seq.Skip(1).Zip(seq, (a, b) => (a, b)).Count(t => t.Item1 < t.Item2);
        }

        private static IEnumerable<long> Sequence(int n)
        {
            var seq = new long[n + 1];
            seq[0] = 0L;
            seq[1] = 1L;
            seq[2] = 1L;
            for (var i = 3; i <= n; i++)
                seq[i] = seq[i - seq[i - 1]] + seq[i - seq[i - 2]];
            return seq;
        }
    }
}
