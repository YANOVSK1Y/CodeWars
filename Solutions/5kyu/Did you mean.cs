

namespace Solutions._5kyu
{
    public class Did_you_mean
    {
        private IEnumerable<string> words;

        public Did_you_mean(IEnumerable<string> words)
        {
            this.words = words;
        }

        public string FindMostSimilar(string term)
        {
            var scores = new Dictionary<string, int>();
            foreach (string word in words)
            {
                var (a, b) = term.Length > word.Length ? (term, word) : (word, term);
                int dl = a.Length - b.Length;
                int diff = int.MaxValue;
                for (int i = 0; i <= dl; i++)
                {
                    string s = a.Substring(i, b.Length);
                    int d = s.Zip(b).Where(t => t.First != t.Second).Count();
                    diff = d < diff ? d : diff;
                }
                scores[word] = diff + dl;
            }
            return scores.OrderBy(kv => kv.Value).First().Key;
        }
    }
}
