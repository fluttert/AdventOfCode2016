using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Challenges
{
    public class Day05
    {
        internal static System.Security.Cryptography.MD5 Md5 = System.Security.Cryptography.MD5.Create();

        public string Part1(string[] input)
        {
            var key = "cxdnnyjw";
            var password = new List<char>();
            int currentIndex = 0;
            while (password.Count < 8)
            {
                Byte[] digest = Md5.ComputeHash(Encoding.UTF8.GetBytes(key + currentIndex ));
                if (digest[0] == 0 && digest[1] == 0 && (digest[2] & 0xF0) == 0)
                {
                    password.Add(BitConverter.ToString(digest, 2, 1)[1]);
                    //Console.WriteLine($"============ FOUND ONE!");
                }
                currentIndex++;
            }
            Console.WriteLine($"Total process up to {currentIndex}");
            Debug.WriteLine($"Total process up to {currentIndex}");
            return new string(password.ToArray());
            // result is based on 8202540 hashes
        }

        public string Part2(string[] input)
        {
            var key = "cxdnnyjw";
            var password = new char[8];
            int currentIndex = 0, charsFound = 0;
            while (charsFound < 8)
            {
                Byte[] digest = Md5.ComputeHash(Encoding.UTF8.GetBytes(key + currentIndex));
                if (digest[0] == 0 && digest[1] == 0 && (digest[2] & 0xF0) == 0)
                {
                    char pos = BitConverter.ToString(digest, 2, 1)[1];
                    if (pos >= '0' && pos <= '7' && password[(pos - '0')] == '\0')
                    {
                        password[(pos - '0')] = BitConverter.ToString(digest, 3, 1)[0];
                        charsFound++;
                        //Console.WriteLine($"============ FOUND ONE!");
                    }
                }
                currentIndex++;
            }
            Debug.WriteLine($"Total process up to {currentIndex}");
            return new string(password.ToArray());
            // result is based on 25370047 hashes 
        }
    }
}