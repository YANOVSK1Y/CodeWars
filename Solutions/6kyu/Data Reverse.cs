
namespace Solutions._6kyu
{
    public static class Data_Reverse
    {
        public static int[] DataReverse(int[] data)
        {
            int[] res = new int[data.Length]; 
            for (int i = 0; i < data.Length; i+=8)
            {
                res[data.Length - i - 1] = data[i + 7];
                res[data.Length - i - 2] = data[i + 6];
                res[data.Length - i - 3] = data[i + 5];
                res[data.Length - i - 4] = data[i + 4];
                res[data.Length - i - 5] = data[i + 3];
                res[data.Length - i - 6] = data[i + 2];
                res[data.Length - i - 7] = data[i + 1];
                res[data.Length - i - 8] = data[i];
            }
            return res;
        }
    }
}
