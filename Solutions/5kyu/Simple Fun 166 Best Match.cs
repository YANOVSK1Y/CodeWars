
namespace Solutions._5kyu
{
    public class Simple_Fun_166_Best_Match
    {
        public int BestMatch(int[] goals1, int[] goals2)
        {
            int[] difference = new int[goals1.Length];
            for (int i = 0; i < goals1.Length; i++)
            {
                difference[i] = goals1[i] - goals2[i];
            }

            int min = 0;
            for (int i = 0; i < difference.Length; i++)
            {
                if (difference[i] < difference[min] || (difference[i] == difference[min] && goals2[i] > goals2[min]))
                {
                    min = i;
                }
            }
            return min;
        }
    }
}
