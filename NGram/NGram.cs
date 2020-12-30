using System;
using System.Collections.Generic;

namespace NGram
{
    public class NGram
    {
        private readonly int N;
        public NGram(int n)
        {
            N = n;
        }

        public List<string> MakeNgram(string text)
        {
            var result = new List<string>();
            var pos = 0;
            while (true)
            {
                var g = text.Substring(pos, N);
                result.Add(g);
                pos++;
                Console.WriteLine(g);
                if (text.Length < pos + N)
                {
                    break;
                }
            }
            return result;
        }
    }
}