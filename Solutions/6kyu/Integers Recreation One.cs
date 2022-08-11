
namespace Solutions._6kyu
{
    public static class Integers_Recreation_One
    {
        public static string listSquared(long m, long n)
        {
            var result = new List<string>();

            for (long number = m; number <= n; number++)
            {
                var divisors = new List<int>();
                long sum = 0;
                for (int div = 1; div <= number; div++)
                {
                    if (number % div == 0)
                        sum += (div * div);
                }

                if (Math.Sqrt(sum) % 2 == 0 || sum == 1)
                    result.Add(string.Format("[{0}, {1}]", number, sum));
            }
            return string.Format("[{0}]", string.Join(", ", result));
        }
    }
}
