using System;
using System.Collections.Generic;

namespace AdventOfCode.Challenges
{
    public class C1
    {
        public int Part1(string input)
        {
            int vertical = 0, horizontal = 0;
            char direction = 'N'; // N E S W
            var instructions = input.Replace(" ", "").Split(',');
            for (int i = 0; i < instructions.Length; i++)
            {
                char leftOrRight = instructions[i][0];
                int distance = int.Parse(instructions[i].Substring(1));
                int multiplier = 1;

                if ((direction == 'N' && leftOrRight == 'L') ||
                    (direction == 'S' && leftOrRight == 'R') ||
                    (direction == 'E' && leftOrRight == 'R') ||
                    (direction == 'W' && leftOrRight == 'L'))
                {
                    multiplier = -1;
                }
                if (i % 2 == 0)
                {
                    direction = multiplier == 1 ? 'E' : 'W';
                    horizontal += (multiplier * distance);
                }
                else
                {
                    direction = multiplier == 1 ? 'N' : 'S';
                    vertical += (multiplier * distance);
                }
            }
            return Math.Abs(horizontal) + Math.Abs(vertical);
        }

        public int Part2(string input)
        {
            var coordinates = new HashSet<Tuple<int, int>>();
            int vertical = 0, horizontal = 0;
            char direction = 'N'; // N E S W
            var instructions = input.Replace(" ", "").Split(',');
            for (int i = 0; i < instructions.Length; i++)
            {
                char leftOrRight = instructions[i][0];
                int distance = int.Parse(instructions[i].Substring(1));
                int multiplier = 1;

                if ((direction == 'N' && leftOrRight == 'L') ||
                    (direction == 'S' && leftOrRight == 'R') ||
                    (direction == 'E' && leftOrRight == 'R') ||
                    (direction == 'W' && leftOrRight == 'L'))
                {
                    multiplier = -1;
                }
                if (i % 2 == 0)
                {
                    direction = multiplier == 1 ? 'E' : 'W';
                    int newHorizontal = horizontal + (multiplier * distance);
                    while (horizontal != newHorizontal) {
                        var coordinate = new Tuple<int, int>(horizontal, vertical);
                        if (coordinates.Contains(coordinate)) { return Math.Abs(horizontal) + Math.Abs(vertical); }
                        coordinates.Add(coordinate);
                        horizontal += multiplier;
                    }
                }
                else
                {
                    direction = multiplier == 1 ? 'N' : 'S';
                    int newVertical = vertical + (multiplier * distance);
                    while (vertical != newVertical)
                    {
                        var coordinate = new Tuple<int, int>(horizontal, vertical);
                        if (coordinates.Contains(coordinate)) { return Math.Abs(horizontal) + Math.Abs(vertical); }
                        coordinates.Add(coordinate);
                        vertical += multiplier;
                    }
                }
            }
            return Math.Abs(horizontal) + Math.Abs(vertical);
        }
    }
}