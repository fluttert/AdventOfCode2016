﻿using System;
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

        public int Part2(string[] input)
        {
            string match = "northpole";
            // the roomname = northpole object storage
            int sectorIdOfNorthPole = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sectorIdOfNorthPole = RealRoomSectorId(input[i]);

                // 0 = decoy chamber
                if (sectorIdOfNorthPole == 0) { continue; }

                char[] encodedLine = input[i].ToCharArray();
                for (int j = 0; j < encodedLine.Length; j++)
                {
                    if (encodedLine[j] == '-')
                    {
                        encodedLine[j] = ' ';
                        continue;
                    }
                    if (encodedLine[j] < 'a' || encodedLine[j] > 'z') { continue; }

                    // shift -> add the sector id, then modulo 26, while subtracting and adding a
                    int newCharIndex = (((int)encodedLine[j] + sectorIdOfNorthPole - (int)'a') % 26) + 'a';
                    encodedLine[j] = (char)newCharIndex;
                }
                string RoomName = new string(encodedLine);
                if (RoomName.IndexOf(match) != -1)
                {
                    return sectorIdOfNorthPole;
                }
            }
            return sectorIdOfNorthPole;
        }

        private int RealRoomSectorId(string encodedData)
        {
            var dict = new Dictionary<char, int>();
            string sectorId = "", checkSum = String.Empty;
            int index = -1;

            // parse the string
            while (index < (encodedData.Length - 1))
            {
                index++;
                char currentChar = encodedData[index];
                if (currentChar == '-') { continue; }
                if (currentChar >= '0' && currentChar <= '9')
                {
                    sectorId += currentChar; continue;
                }
                if (currentChar == '[')
                {
                    checkSum = encodedData.Substring(index + 1, 5);
                    index += 7; continue;
                }
                if (!dict.ContainsKey(currentChar)) { dict.Add(currentChar, 0); }
                dict[currentChar]++;
            }

            // using the power of LINQ to get the top 5 chars in alphabetical order
            var fivePopular = new string((from kp in dict orderby kp.Value descending, kp.Key ascending select kp.Key).Take(5).ToArray());

            return fivePopular == checkSum ? int.Parse(sectorId) : 0;
        }
    }
}