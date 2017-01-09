using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Challenges
{
    public class Day15
    {
        public int Part1(string[] input)
        {
            // Disc #1 has 5 positions; at time=0, it is at position 4.
            int timePassed = 0;
            int maxPosition = int.MaxValue;
            bool fallthrough = false;

            Disc[] discs = new Disc[input.Length];
            for (int row = 0; row < input.Length; row++)
            {
                string[] pieces = input[row].Split(new char[] { ' ', '=', '.' }, StringSplitOptions.RemoveEmptyEntries);
                int positions = int.Parse(pieces[3]);
                int currentPosition = int.Parse(pieces[(pieces.Length - 1)]);
                if (positions < maxPosition) { maxPosition = positions; }
                discs[row] = new Disc(positions, currentPosition);
            }

            while (!fallthrough)
            {
                int ballPosition = -1;
                bool curFallthrough = true;
                for (int d = 0; d < discs.Length; d++)
                {
                    int curPos = discs[d].AddTime(timePassed + d + 1);
                    if (curPos >= maxPosition)
                    {
                        timePassed++;
                        curFallthrough = false;
                        break;
                    }

                    if (d == 0) { ballPosition = curPos; }
                    else
                    {
                        if (ballPosition != curPos)
                        {
                            timePassed++;
                            curFallthrough = false;
                            break;
                        }
                    }
                }
                if (curFallthrough)
                {
                    fallthrough = true;
                }
                
                // emergency exit
                if (timePassed > 1e+7) { break; }
            }

            return timePassed;
        }

        public int Part2(string[] input)
        {
            var addedDisk = input.ToList();
            addedDisk.Add("Disc #0 has 11 positions; at time=0, it is at position 0.");
            return Part1(addedDisk.ToArray());
        }
    }

    public class Disc
    {
        private int positions;
        private int startPosition;

        public Disc(int positions, int positionAtStart)
        {
            this.positions = positions;
            this.startPosition = positionAtStart;
        }

        public int AddTime(int seconds)
        {
            return (startPosition + seconds) % positions;
        }
    }
}