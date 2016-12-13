using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Challenges
{
    public class Day13
    {
        private const char openSpace = '.';
        private const char wall = '#';

        public int Part1(string[] input)
        {
            return 0;
        }

        public int Part2(string[] input)
        {
            return 0;
        }

        public char[][] CreateMaze(int seed, int height, int width)
        {
            char[][] maze = new char[height][];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    // formula: x*x + 3*x + 2*x*y + y + y*y
                    int sum = seed + (j * j) + (3 * j) + (2 * j * i) + i + (i * i);
                    maze[i][j] = IsBinarySumEven(sum) ? openSpace : wall;
                }
            }

            return maze;
        }

        public bool IsBinarySumEven(int sum)
        {
            // based on https://davidzych.com/converting-an-int-to-a-binary-string-in-c/
            int ones = 0;
            while (sum > 0)
            {
                if ((sum & 1) == 1)
                {
                    ones++;
                }
                sum = sum >> 1;
            }
            return ones % 2 == 0;
        }
    }
}