
using System.Text;


namespace Solutions._5kyu
{
    public class ASCII85_Encoding_and_Decoding
    {
        public static string toAscii85(byte[] data)
        {
            if (data.Length == 0) return "<~~>";
            int nblock = (data.Length - 1) / 4 + 1;
            int npad = 4 * nblock - data.Length, b = 0;
            var buffer = new byte[5 * nblock + 10];
            buffer[b++] = 60; buffer[b++] = 126;

            for (uint d = 0, x = 0; d < data.Length; x = 0)
            {
                for (int s = 24; s >= 0 && d < data.Length; s -= 8)
                    x |= (uint)(data[d++] << s);

                if (x == 0) { buffer[b++] = 122; continue; }
                for (int s = 4; s > -5; s -= 2, x /= 85)
                    buffer[b++ + s] = (byte)(x % 85 + 33);
            }

            if (npad > 0 && buffer[b - 1] == 122)
            {
                buffer[b - 1] = 33;
                buffer[b++] = 33;
                buffer[b++] = 33;
                buffer[b++] = 33;
                buffer[b++] = 33;
            }

            b -= npad;
            buffer[b++] = 126; buffer[b++] = 62;
            return Encoding.ASCII.GetString(buffer, 0, b);
        }

        public static byte[] fromAscii85(string sdata)
        {
            var s = sdata.IndexOf("<~") + 2;
            var e = sdata.IndexOf("~>", s);
            if (s == -1 || e == -1) return new byte[0];

            var data = sdata[s..e]
                .Replace("z", "!!!!!")
                .Select(c => c - 33)
                .Where(c => c >= 0 && c < 85)
                .ToArray();

            if (data.Length == 0) return new byte[0];
            var nblock = (data.Length - 1) / 5 + 1;
            int npad = 5 * nblock - data.Length, b = 0;
            var buffer = new byte[4 * nblock - npad];

            for (uint d = 0, x = 0, i = 0; d < data.Length; x = 0, i = 0)
            {
                while (d < data.Length && i++ < 5)
                    x = (uint)(x * 85 + data[d++]);
                while (i++ < 5) x = 85 * x + 84;
                for (var j = 24; j >= 0 && b < buffer.Length; j -= 8)
                    buffer[b++] = (byte)((x >> j) & 0xff);
            }

            return buffer;
        }
    }
}
