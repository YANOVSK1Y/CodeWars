
namespace Solutions._6kyu
{
    /// <summary>
    /// Kata Task

    /// How many deaf rats are there?
    /// 
    ///Legend
    ///P = The Pied Piper
    ///O ~ = Rat going left
    ///~O = Rat going right
    ///
    ///Example
    ///ex1 ~O~O~O~O P has 0 deaf rats
    ///ex2 P O ~O~ ~O O ~has 1 deaf rat
    /// ex3 ~O~O~O~OP~O~OO~has 2 deaf rats
    /// </summary>
    public static class The_Deaf_Rats_of_Hamelin
    {
        public static int CountDeafRats(string town)
        {
            var rats = town.Replace(" ", "").Split('P');
            var leftCount = rats[0].Where((x, i) => i % 2 == 1).Count(x => x == '~');
            var rightCount = rats[1].Where((x, i) => i % 2 == 0).Count(x => x == '~');
            return leftCount + rightCount;
        }
    }
}
