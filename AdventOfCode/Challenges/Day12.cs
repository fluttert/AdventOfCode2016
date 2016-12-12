using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Challenges
{
    public class Day12
    {
        public int Part1(string[] input, Dictionary<string, int> initRegisters = null)
        {
            string registernames = "abcd";
            var registers = initRegisters; 
            if (registers == null) { registers = new Dictionary<string, int>() { { "a", 0 }, { "b", 0 }, { "c", 0 }, { "d", 0 } }; }
            int lineNumber = 0;
            while (lineNumber < input.Length)
            {
                var parts = input[lineNumber].Trim().Split(' ');
                string instruction = parts[0];
                if (instruction == "inc") { registers[parts[1]]++; }
                if (instruction == "dec") { registers[parts[1]]--; }
                if (instruction == "cpy")
                {
                    int copyValue =
                        (registernames.IndexOf(parts[1]) != -1) ?
                        registers[parts[1]] : int.Parse(parts[1]);
                    registers[parts[2]] = copyValue;
                }
                if (instruction == "jnz")
                {
                    int jumpNonZeroValue =
                        (registernames.IndexOf(parts[1]) != -1) ?
                        registers[parts[1]] : int.Parse(parts[1]);
                    if (jumpNonZeroValue != 0)
                    {
                        lineNumber += int.Parse(parts[2]);
                        continue;
                    }
                }
                lineNumber++;
            }
            return registers["a"];
        }

        public int Part2(string[] input)
        {
            return Part1(input, new Dictionary<string, int>() { { "a", 0 }, { "b", 0 }, { "c", 1 }, { "d", 0 } });
        }
    }
}