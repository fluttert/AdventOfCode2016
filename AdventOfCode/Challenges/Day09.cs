using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Challenges
{
    public class Day09
    {
        public string Part1(string input) {
            StringBuilder sb = new StringBuilder();
            int curIndex = 0;
            while (curIndex < input.Length) {
                if (input[curIndex] != '(') {
                    sb.Append(input[curIndex]);
                    curIndex++; continue;
                }
                int endParenthesis = input.IndexOf(')', curIndex);
                int[] marker = Array.ConvertAll(input.Substring(curIndex + 1, endParenthesis - curIndex -1).Split('x'), int.Parse);
                string repeat = input.Substring(endParenthesis + 1, marker[0]);
                for (int i = 0; i < marker[1]; i++) {
                    sb.Append(repeat);
                }
                curIndex = endParenthesis + 1 + marker[0];
            }
            return sb.ToString();
        }
        public long Part2(string input)
        {
            // Parse(A(8x3)B(1x6)BCD)
            // == A + 3 * Parse(B(1x6)BC) + D 
            // == A + 3 * ( B + 6* (Parse(B) + C) + D
            // == 1 + 3 * ( 1 + 6 * (1) + 1 ) + 1 = 1 + 3 * ( 8 ) + 1 = 1 + 24 + 1 = 26
            long decompressedLength = 0;
            int curIndex = 0;
            while (curIndex < input.Length)
            {
                if (input[curIndex] != '(') {
                    decompressedLength++;
                    curIndex++; continue;
                }
                int endParenthesis = input.IndexOf(')', curIndex);
                int[] marker = Array.ConvertAll(input.Substring(curIndex + 1, endParenthesis - curIndex - 1).Split('x'), int.Parse);
                string repeatSubstring = input.Substring(endParenthesis + 1, marker[0]);
                decompressedLength += (marker[1] * (Part2(repeatSubstring)));
                curIndex = endParenthesis + 1 + marker[0];
            }
            return decompressedLength;
        }
    }
}
