using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Challenges
{
    public class Day06
    {
        public string Part1(string[] input)
        {
            var message = new List<char>();
            for (int column = 0; column < input[0].Length; column++)
            {
                int[] chars = new int[26];
                for (int row = 0; row < input.Length; row++)
                {
                    chars[(input[row][column] - 'a')]++;
                }
                int max = -1, index = -1; ;
                for (int i = 0; i < chars.Length; i++)
                {
                    if (chars[i] > max) { max = chars[i]; index = i; }
                }
                message.Add((char)('a' + index));
            }
            return new string(message.ToArray());
        }

        public string Part2(string[] input)
        {
            var message = new List<char>();
            for (int column = 0; column < input[0].Length; column++)
            {
                int[] chars = new int[26];
                for (int row = 0; row < input.Length; row++)
                {
                    chars[(input[row][column] - 'a')]++;
                }
                int min = Int32.MaxValue, index = -1; ;
                for (int i = 0; i < chars.Length; i++)
                {
                    if (chars[i] != 0 && chars[i] < min) { min = chars[i]; index = i; }
                }
                message.Add((char)('a' + index));
            }
            return new string(message.ToArray());
        }
    }
}