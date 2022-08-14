
namespace Solutions._6kyu
{
    public static class Bit_Counting
    {
        public static int CountBits(int n)
        {
            return Convert.ToString(Convert.ToString(n, 2)).Where(item => item.Equals('1')).Count(); 
        }
    }
}
