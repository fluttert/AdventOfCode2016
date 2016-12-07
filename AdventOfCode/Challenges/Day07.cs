using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Challenges
{
    public class Day07
    {
        public int Part1(string[] input)
        {
            int tlsSupported = 0;
            foreach (string line in input)
            {
                int brackets = 0;
                bool foundAbba = false, foundInBrackets = false;
                for (int i = 0; i < (line.Length - 3); i++)
                {
                    if (line[i] == '[' || line[i] == ']')
                    {
                        brackets += line[i] == '[' ? 1 : -1;
                        continue;
                    }
                    if (line[i] != line[i + 1] && line[i] == line[i + 3] && line[i + 1] == line[i + 2])
                    {
                        if (brackets > 0) { foundInBrackets = true; }
                        foundAbba = true;
                    }
                }
                tlsSupported += foundAbba && !foundInBrackets ? 1 : 0;
            }
            return tlsSupported;
        }

        public int Part2(string[] input)
        {
            int sslSupported = 0;
            foreach (string line in input)
            {
                int brackets = 0;
                var aba = new HashSet<string>();
                var bab = new HashSet<string>();
                for (int i = 0; i < (line.Length - 2); i++)
                {
                    if (line[i] == '[' || line[i] == ']')
                    {
                        brackets += line[i] == '[' ? 1 : -1;
                        continue;
                    }
                    if (line[i] != line[i + 1] && line[i] == line[i + 2])
                    {
                        string curSubstring = "" + line[i] + line[i + 1] + line[i + 2];
                        string inverse = "" + line[i + 1] + line[i] + line[i + 1];
                        if (brackets == 0)
                        {
                            if (bab.Contains(inverse)) { sslSupported++; break; }
                            aba.Add(curSubstring);
                        }
                        else
                        {
                            if (aba.Contains(inverse)) { sslSupported++; break; }
                            bab.Add(curSubstring);
                        }
                    }
                }
            }
            return sslSupported;
        }
    }
}