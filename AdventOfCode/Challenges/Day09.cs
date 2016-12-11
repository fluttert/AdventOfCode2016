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
                string repeatPart = input.Substring(endParenthesis + 1, marker[0]);
                decompressedLength += (marker[1] * (Part2(repeatPart)));
                curIndex = endParenthesis + 1 + marker[0];
            }
            return decompressedLength;
        }
    }
}
