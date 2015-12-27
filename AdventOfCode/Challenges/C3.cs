using System;
using System.Collections.Generic;

namespace AdventOfCode.Challenges
{
    internal class C3
    {
        public int Part1(string input)
        {
            var houses = new HashSet<Tuple<int, int>>();
            int x = 0, y = 0;
            houses.Add(new Tuple<int, int>(0, 0));

            foreach (char c in input)
            {
                if (c == '^') { y++; }
                if (c == 'v') { y--; }
                if (c == '>') { x++; }
                if (c == '<') { x--; }
                houses.Add(new Tuple<int, int>(x, y));
            }

            return houses.Count;
        }

        public int Part2(string input)
        {
            var houses = new HashSet<Tuple<int, int>>();
            int x1 = 0, x2 = 0, y1 = 0, y2 = 0;
            bool realSanta = true;
            houses.Add(new Tuple<int, int>(0, 0));

            foreach (char c in input)
            {
                int x = x1, y = y1;
                if (realSanta) { x = x2; y = y2; }
                
                if (c == '^') { y++; }
                if (c == 'v') { y--; }
                if (c == '>') { x++; }
                if (c == '<') { x--; }
                houses.Add(new Tuple<int, int>(x, y));

                if (realSanta) { x2 = x; y2 = y; }
                else { x1 = x; y1 = y; }
                realSanta = !realSanta;
            }
            

            return houses.Count;
        }
    }
}