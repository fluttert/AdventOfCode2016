﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Challenges
{
    public class Day14
    {
        internal static System.Security.Cryptography.MD5 Md5 = System.Security.Cryptography.MD5.Create();

        public int Part1(string[] input)
        {
            string salt = input[0].Trim();
            int currentIndex = 0;
            int keysFound = 0;
            string[] triplets = new string[1000];
            string[] quintets = new string[1000];
            string[] hashes = new string[1000];
            while (keysFound < 64 && currentIndex < 1e+6)
            {
                // search the current space (so n-1000)
                int indexModThousand = currentIndex % 1000;
                if (!string.IsNullOrEmpty(triplets[indexModThousand]))
                {
                    bool keyFound = false;
                    char curChar = triplets[indexModThousand][0];
                    for (int j = 0; j < 1000; j++)
                    {
                        // skip yourself
                        if (j == indexModThousand) { continue; }


                        if (quintets[j].Contains(curChar))
                        {
                            keyFound = true;
                            keysFound++;
                            Debug.WriteLine($"Found key for index: {currentIndex - 1000}");
                            break;
                        }
                    }

                    if (keysFound == 64)
                    {
                        return currentIndex - 1000;
                    }
                }

                // overwrite with new entry (= n)
                string hash = BitConverter.ToString(
                    Md5.ComputeHash(
                        Encoding.UTF8.GetBytes(salt + currentIndex)
                        )
                     ).Replace("-", "");

                triplets[indexModThousand] = ConsecutiveChars(hash, 3);
                quintets[indexModThousand] = ConsecutiveChars(hash, 5);
                currentIndex++;
            }
            return currentIndex;
        }

        public string ConsecutiveChars(string input, int length)
        {
            HashSet<char> consecutivechars = new HashSet<char>();
            for (int i = length - 1; i < input.Length; i++)
            {
                char curChar = input[i];
                bool consecutive = true;
                for (int j = 1; j < length; j++)
                {
                    if (input[i - j] != curChar)
                    {
                        consecutive = false;
                        break;
                    }
                }
                if (consecutive) { consecutivechars.Add(curChar); }
            }
            return new string(consecutivechars.ToArray());
        }

        public int Part2(string[] input)
        {
            return 0;
        }
    }
}