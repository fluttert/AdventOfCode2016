using System.Collections.Generic;

namespace AdventOfCode.Challenges
{
    public class Day2
    {
        public string Part1(string[] input)
        {
            char[][] keypad = { new[] { '1', '2', '3' }, new[] { '4', '5', '6' }, new[] { '7', '8', '9' } };
            int vertical = 1, horizontal = 1;
            List<char> result = new List<char>();
            for (int i = 0; i < input.Length; i++) {
                string line = input[i].Trim();
                foreach (char instruction in line) {
                    if (instruction == 'U') { vertical = (vertical == 0 ? 0 : vertical - 1); }
                    if (instruction == 'D') { vertical = (vertical == 2 ? 2 : vertical + 1); }
                    if (instruction == 'L') { horizontal = (horizontal == 0 ? 0 : horizontal - 1); }
                    if (instruction == 'R') { horizontal = (horizontal == 2 ? 2 : horizontal + 1); }
                }
                result.Add(keypad[vertical][horizontal]);
            }
            return new string(result.ToArray());
        }
    }
}