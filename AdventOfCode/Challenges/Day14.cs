using System;
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
            

            while (currentIndex < 1e+6)
            {
                int indexModThousand = currentIndex % 1000;
                // search back
                if (!string.IsNullOrEmpty(triplets[indexModThousand])) {
                    bool keyFound = false;
                    for (int i = 0; i < triplets[indexModThousand].Length; i++) {
                        char curChar = triplets[indexModThousand][i];
                        if (keyFound) { break; }
                        for (int j = 0; j < 1000; j++) {
                            if (quintets[j].Contains(curChar)) {
                                //Debug.WriteLine($"Found quintent for index: {currentIndex-1000} , it was a {curChar}");
                                keyFound = true;
                                break;
                            }
                        }
                    }

                    // keyfound
                    if (keyFound) {
                        keysFound++;
                        Debug.WriteLine($"Found key for index: {currentIndex - 1000}");
                    }
                    if (keysFound == 64)
                    {
                        return currentIndex - 1000;
                    }

                }
                if (currentIndex == 1000) {
                    var a = 123;
                }

                // overwrite with new entry
                string hash = BitConverter.ToString(
                    Md5.ComputeHash(
                        Encoding.UTF8.GetBytes(salt + currentIndex)
                        )
                     ).Replace("-","");
                
                triplets[indexModThousand] = ConsecutiveChars(hash, 3);
                quintets[indexModThousand] = ConsecutiveChars(hash, 5);
                currentIndex++;
            }
            return 0;
        }

        public string ConsecutiveChars(string input, int length)
        {
            StringBuilder sb = new StringBuilder();
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
                if (consecutive) { sb.Append(curChar); }
            }
            return sb.ToString();
        }

        public int Part2(string[] input)
        {
            return 0;
        }
    }
}