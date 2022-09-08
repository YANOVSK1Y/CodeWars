using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions._5kyu
{
    public class Pick_peaks
    {
        public static Dictionary<string, List<int>> GetPeaks(int[] arr)
        {
            int pos = 0, peaks = 0;

            Dictionary<string, List<int>> dictionary = new Dictionary<string, List<int>>();
            dictionary.Add("pos", new List<int>());
            dictionary.Add("peaks", new List<int>());
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    pos = i;
                    peaks = arr[i];
                }
                if (arr[i] > arr[i + 1] && pos != 0)
                {
                    dictionary["pos"].Add(pos);
                    dictionary["peaks"].Add(peaks);
                    pos = 0;
                    peaks = 0;
                }
            }

            return dictionary;
        }
    }
}
