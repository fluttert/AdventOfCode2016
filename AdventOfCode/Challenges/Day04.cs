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
                sumOfSectorIds += RealRoomSectorId(input[i]);
            }
            return sumOfSectorIds;
        }

        public int Part2(string[] input) {
            string match = "North Pole";
            int sectorIdOfNorthPole=0;
            for (int i = 0; i < input.Length; i++)
            {
                sectorIdOfNorthPole = RealRoomSectorId(input[i]);
                if (sectorIdOfNorthPole == 0) { continue; }


            }
            return sectorIdOfNorthPole;
        }


        private int RealRoomSectorId(string encodedData) {
            int realRoomSectorId = 0;
            var dict = new Dictionary<char, int>();
            string sectorId = "", checkSum = String.Empty;
            int index = 0;
            
            // parse the string 
            while (index < (encodedData.Length - 1))
            {
                char currentChar = encodedData[index];
                if (currentChar == '-') { index++; continue; }
                if (currentChar >= '0' && currentChar <= '9')
                {
                    sectorId += currentChar; index++; continue;
                }
                if (currentChar == '[')
                {
                    checkSum = encodedData.Substring(index + 1, 5);
                    index += 7; continue;
                }
                if (!dict.ContainsKey(currentChar)) { dict.Add(currentChar, 0); }
                dict[currentChar]++;
                index++;
            }
            
            // using the power of LINQ to get the top 5 chars in alphabetical order
            var fivePopular = new string((from kp in dict orderby kp.Value descending, kp.Key ascending select kp.Key).Take(5).ToArray());
            if (fivePopular == checkSum)
            {
                realRoomSectorId = int.Parse(sectorId);
            }
            return realRoomSectorId;
        }
    }
}