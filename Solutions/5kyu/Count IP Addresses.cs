

namespace Solutions._5kyu
{
    public class Count_IP_Addresses
    {
        public static long IpsBetween(string start, string end)
        {
            return IpToNumber(end) - IpToNumber(start);
        }

        public static long IpToNumber(string ip)
        {
            var ints = ip.Split('.').Select(long.Parse).Reverse().ToArray();
            long value = 0;
            for (int i = 0; i < 4; i++)
            {
                value += ints[i] * (long)Math.Pow(256, i);
            }

            return value;
        }
    }
}
