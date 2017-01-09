﻿using System.Collections.Generic;
using System.Text;

namespace AdventOfCode
{
    public class Day16
    {
        public string Part1(string[] input, int disksize = 272)
        {
            string data = input[0];
            
            // data generation
            while (data.Length < disksize)
            {
                char[] extraData = new char[data.Length];
                for (int i = 0; i < data.Length; i++)
                {
                    char toAdd = '1';
                    if (data[i] == '1') { toAdd = '0'; }
                    extraData[(data.Length - 1 - i)] = toAdd;
                }
                data = data + "0" + new string(extraData);
            }

            // checksum
            List<char> checksum = new List<char>();
            for (int i = 0; i < disksize; i++) {
                checksum.Add(data[i]);
            }
            while (checksum.Count % 2 == 0) {
                List<char> newChecksum = new List<char>();
                for (int i = 0; i < checksum.Count; i += 2) {
                    if (checksum[i] == checksum[i + 1])
                    {
                        newChecksum.Add('1');
                    }
                    else {
                        newChecksum.Add('0');
                    }
                }
                checksum = newChecksum;
            }
            return new string(checksum.ToArray());
        }

        public string Part2(string[] input)
        {
            return string.Empty;
        }
    }
}