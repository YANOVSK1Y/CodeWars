
namespace Solutions._6kyu
{

    /// <summary>
    /// Write a function that takes in a string of one or more words,
    /// and returns the same string, but with all five or more 
    /// letter words reversed (Just like the name of this Kata). 
    /// Strings passed in will consist of only letters and spaces. 
    /// Spaces will be included only when more than one word is present.
    /// </summary>
    public static class Stop_gninnipS_My_sdroW
    {
        public static string SpinWords(string sentence)
        {
            return string.Join(" ", sentence.Split(' ').Select(str => str.Length >= 5 ? new string(str.Reverse().ToArray()) : str));
        }
    }
}
