using System;
using System.Collections.Generic;
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

                if (currentIndex % 100000 == 0) { Console.WriteLine($"Processed up to {currentIndex}"); }
            }
            Console.WriteLine($"Total process up to {currentIndex}");
            return new string(password.ToArray());
        }

        /// <summary>
        /// Reference implementation from MSDN
        /// https://msdn.microsoft.com/en-us/library/system.security.cryptography.md5(v=vs.110).aspx
        /// </summary>
        /// <param name="md5Hash"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        internal static string GetMd5Hash(string input)
        {
            byte[] data = System.Security.Cryptography.MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}