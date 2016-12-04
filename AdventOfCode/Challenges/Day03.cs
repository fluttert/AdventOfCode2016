using System;

namespace AdventOfCode.Challenges
{
    public class Day03
    {
        public int Part1(string[] input)
        {
            int possibleTriangles = 0;
            for (int index = 0; index < input.Length; index++)
            {
                string[] tmp = input[index].Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int[] sides = Array.ConvertAll(tmp, int.Parse);
                Array.Sort(sides);
                if ((sides[0] + sides[1]) > sides[2])
                {
                    possibleTriangles++;
                }
            }
            return possibleTriangles;
        }

        public int Part2(string[] input)
        {
            int possibleTriangles = 0;
            for (int index = 0; index < input.Length; index += 3)
            {
                if (input.Length < (index + 2)) { continue; }
                int[] line1 = Array.ConvertAll(input[index].Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);
                int[] line2 = Array.ConvertAll(input[index + 1].Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);
                int[] line3 = Array.ConvertAll(input[index + 2].Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);
                for (int i = 0; i < 3; i++)
                {
                    int[] sides = new[] { line1[i], line2[i], line3[i] };
                    Array.Sort(sides);
                    if ((sides[0] + sides[1]) > sides[2])
                    {
                        possibleTriangles++;
                    }
                }
            }
            return possibleTriangles;
        }
    }
}