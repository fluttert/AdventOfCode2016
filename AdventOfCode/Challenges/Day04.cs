using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class Day04
    {
        public int Part1(string[] input)
        {
            int sumOfSectorIds = 0;
            for (int i = 0; i < input.Length; i++)
            {
                var dict = new Dictionary<char, int>();
                string sectorId = "", checkSum = String.Empty;
                int index = 0;
                while (index< (input[i].Length - 1))
                {
                    char currentChar = input[i][index];
                    if (currentChar == '-') { index++; continue; }
                    if (currentChar >= '0' && currentChar <= '9')
                    {
                        sectorId += currentChar; index++; continue ;
                    }
                    if (currentChar == '[')
                    {
                        checkSum = input[i].Substring(index + 1, 5);
                        index += 7; continue;
                    }
                    if (!dict.ContainsKey(currentChar)) { dict.Add(currentChar, 0); }
                    dict[currentChar]++;
                    index++;
                }
                // power of LINQ
                var fivePopular = new string((from kp in dict orderby kp.Value descending, kp.Key ascending select kp.Key).Take(5).ToArray());
                if (fivePopular == checkSum)
                {
                    sumOfSectorIds += int.Parse(sectorId);
                }
            }
            return sumOfSectorIds;
        }
    }
}