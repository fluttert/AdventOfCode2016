using System;
using System.Linq;

namespace AdventOfCode.Challenges
{
    public class C6
    {
        public int Part1(string[] input)
        {
            int lightsOn = 0;

            // set up the light matrix of 1000 x 1000 (easy)
            bool[][] m = new bool[1000][];
            for (int i = 0; i < 1000; i++) { m[i] = new bool[1000]; }

            // transform
            foreach (string line in input)
            {
                if (string.IsNullOrWhiteSpace(line)) { continue; }
                // by ditching 'Turn ' we get all 4 segments
                string[] segments = line.Replace("turn ", "").Split(' ');
                // like toggle 461,550 through 564,900
                int[] startPos = Array.ConvertAll(segments[1].Split(','), a => int.Parse(a));
                int[] endPos = Array.ConvertAll(segments[3].Split(','), a => int.Parse(a));
                for (int i = startPos[0]; i <= endPos[0]; i++)
                {
                    for (int j = startPos[1]; j <= endPos[1]; j++)
                    {
                        if (segments[0] == "toggle") { m[i][j] = !m[i][j]; }
                        if (segments[0] == "on") { m[i][j] = true; }
                        if (segments[0] == "off") { m[i][j] = false; }
                    }
                }
            }
            for (int i = 0; i < m.Length; i++)
            {
                lightsOn += m[i].Count(a => a);
            }
            return lightsOn;
        }

        public int Part2(string[] input)
        {
            int lightsOn = 0;

            // set up the light matrix of 1000 x 1000 (easy)
            int[][] m = new int[1000][];
            for (int i = 0; i < 1000; i++) { m[i] = new int[1000]; }

            // transform
            foreach (string line in input)
            {
                if (string.IsNullOrWhiteSpace(line)) { continue; }
                // by ditching 'Turn ' we get all 4 segments
                string[] segments = line.Replace("turn ", "").Split(' ');
                // like toggle 461,550 through 564,900
                int[] startPos = Array.ConvertAll(segments[1].Split(','), a => int.Parse(a));
                int[] endPos = Array.ConvertAll(segments[3].Split(','), a => int.Parse(a));
                for (int i = startPos[0]; i <= endPos[0]; i++)
                {
                    for (int j = startPos[1]; j <= endPos[1]; j++)
                    {
                        if (segments[0] == "toggle") { m[i][j] = m[i][j]+2; }
                        if (segments[0] == "on") { m[i][j] = m[i][j] + 1; }
                        if (segments[0] == "off") { m[i][j] = m[i][j] - 1 >= 0 ? m[i][j] - 1 : 0; }
                    }
                }
            }
            for (int i = 0; i < m.Length; i++)
            {
                lightsOn += m[i].Sum(a => a);
            }
            return lightsOn;
        }
    }
}