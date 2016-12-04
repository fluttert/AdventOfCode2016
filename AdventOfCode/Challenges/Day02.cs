using System.Collections.Generic;

namespace AdventOfCode.Challenges
{
    public class Day02
    {
        public string Part1(string[] input)
        {
            string[] keypad = { "123", "456", "789" };
            int vertical = 1, horizontal = 1;
            List<char> result = new List<char>();
            for (int i = 0; i < input.Length; i++)
            {
                string line = input[i].Trim();
                foreach (char instruction in line)
                {
                    if (instruction == 'U' && vertical>0) { vertical -= 1; }
                    if (instruction == 'D' && vertical<2) { vertical += 1; }
                    if (instruction == 'L' && horizontal>0) { horizontal -= 1; }
                    if (instruction == 'R' && horizontal<2) { horizontal += 1; }
                }
                result.Add(keypad[vertical][horizontal]);
            }
            return new string(result.ToArray());
        }

        public string Part2(string[] input)
        {
            string[] keypad = { "0000000", "0001000", "0023400", "0567890", "00ABC00", "000D000", "0000000" };
            int vertical = 3, horizontal = 1;
            List<char> result = new List<char>();
            for (int i = 0; i < input.Length; i++)
            {
                string line = input[i].Trim();
                foreach (char instruction in line)
                {
                    if (instruction == 'U') { vertical = (keypad[vertical - 1][horizontal] == '0' ? vertical : vertical - 1); }
                    if (instruction == 'D') { vertical = (keypad[vertical + 1][horizontal] == '0' ? vertical : vertical + 1); }
                    if (instruction == 'L') { horizontal = (keypad[vertical][horizontal - 1] == '0' ? horizontal : horizontal - 1); }
                    if (instruction == 'R') { horizontal = (keypad[vertical][horizontal + 1] == '0' ? horizontal : horizontal + 1); }
                }
                result.Add(keypad[vertical][horizontal]);
            }
            return new string(result.ToArray());
        }
    }
}