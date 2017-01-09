﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Challenges
{
    public class Day18
    {

        public int Part1(string[] input, int rowsRequired = 40) {
            int safeTiles = 0;
            int rowsDone = 0;
            int rowWidth = input[0].Length + 2; // added SAFE tile on the edges
            bool[] traps = new bool[rowWidth];

            // init
            for (int i = 0; i < input[0].Length; i++) {
                if (input[0][i] == '^') { traps[i + 1] = true; }
            }
            
            while (rowsDone < rowsRequired) {
                // count current safe tiles
                safeTiles += (traps.Count(a => !a) - 2);
                rowsDone++;

                var nextRowOfTraps = new bool[rowWidth];
                for (int i = 1; i < (rowWidth - 1); i++) {
                    if (traps[i - 1] && traps[i] && !traps[i + 1]) { nextRowOfTraps[i] = true; }
                    if (!traps[i - 1] && traps[i] && traps[i + 1]) { nextRowOfTraps[i] = true; }
                    if (!traps[i - 1] && !traps[i] && traps[i + 1]) { nextRowOfTraps[i] = true; }
                    if (traps[i - 1] && !traps[i] && !traps[i + 1]) { nextRowOfTraps[i] = true; }
                }
                traps = nextRowOfTraps;
            }
            return safeTiles;
        }

        public int Part2(string[] input) {
            return Part1(input, 400000);
        }
    }
}
