using System.Linq;

namespace AdventOfCode.Challenges
{
    internal class C5
    {
        public int Part1(string[] input)
        {
            int nice = 0;
            string[] badPieces = new string[] { "ab", "cd", "pq", "xy" };
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            foreach (string line in input)
            {
                var line1 = line.Trim();
                // line contains a bad piece
                if (badPieces.Any(a => line1.IndexOf(a) >= 0)) { continue; }

                // three vowel
                int amountVowels = vowels.Sum(a => line1.Count(b => b == a));
                if (amountVowels < 3) { continue; }

                // double chars
                for (int i = 0; i < line1.Length - 1; i++)
                {
                    if (line1[i] == line1[i + 1])
                    {
                        nice++;
                        break;
                    }
                }
            }

            return nice;
        }

        public int Part2(string[] input)
        {
            int nice = 0;
            foreach (string line in input)
            {
                bool twoPair = false, middleLetter = false;
                for (int i = 0; i < line.Length-2; i++)
                {
                    if (line[i] == line[i + 2]) { middleLetter = true; }

                    var sub = ""+line[i] + line[i+1];
                    if (line.LastIndexOf(sub) - line.IndexOf(sub)>1 )
                    {
                        twoPair = true;
                    }
                }
                if (twoPair && middleLetter) { nice++; }
            }

            return nice;
        }
    }
}