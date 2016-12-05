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
        public string Part1(string[] input)
        {
            var key = "cxdnnyjw";
            var password = new List<char>();
            int currentIndex = 0;
            while (password.Count < 8)
            {
                if (GetMd5Hash(key + currentIndex).StartsWith("00000"))
                {
                    password.Add(GetMd5Hash(key + currentIndex)[5]);
                    Console.WriteLine($"============ FOUND ONE!");
                }
                currentIndex++;

                //if (currentIndex % 100000 == 0) { Console.WriteLine($"Processed up to {currentIndex}"); }
            }
            Console.WriteLine($"Total process up to {currentIndex}");
            Debug.WriteLine($"Total process up to {currentIndex}");
            return new string(password.ToArray());
            // result is based on 8202540 hashes calculated in 29293 ms
        }

        public string Part2(string[] input)
        {
            var key = "cxdnnyjw";
            var password = new char[8];
            int currentIndex = 0, charsFound =0;
            while (charsFound < 8)
            {
                var curPassword = GetMd5Hash(key + currentIndex);
                if (curPassword.StartsWith("00000"))
                {
                    char pos = curPassword[5];
                    if(pos>='0' && pos<= '7' && password[(pos-'0')]=='\0')
                    {
                        password[(pos - '0')] = curPassword[6];
                        charsFound++;
                        Console.WriteLine($"============ FOUND ONE!");
                    }
                    
                }
                currentIndex++;

                //if (currentIndex % 100000 == 0) { Console.WriteLine($"Processed up to {currentIndex}"); }
            }
            Debug.WriteLine($"Total process up to {currentIndex}");
            return new string(password.ToArray());
            // result is based on 25370047 hashes calculated in 100544 ms
        }

        internal static System.Security.Cryptography.MD5 Md5 = System.Security.Cryptography.MD5.Create();

        /// <summary>
        /// Reference implementation from MSDN
        /// https://msdn.microsoft.com/en-us/library/system.security.cryptography.md5(v=vs.110).aspx
        /// </summary>
        internal static string GetMd5Hash(string input)
        {
            byte[] data = Md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}