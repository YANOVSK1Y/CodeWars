
namespace Solutions._5kyu
{
    public class Lazy_Repeater
    {
        public static Func<char> MakeLooper(string str)
        {
            int idx = 0;

            return () => str[idx++ % str.Length];
        }
    }
}
