using System.Security.Cryptography;
using System.Text;

namespace AdventOfCode.Challenges
{
    internal class C4
    {
        public int Part1(string input)
        {
            int result = 0;
            for (int i = 0; i < int.MaxValue; i++)
            {
                string tmp = CreateMD5(input + i);
                if (tmp.StartsWith("00000"))
                {
                    result = i;
                    break;
                }
            }

            return result;
        }

        public int Part2(string input)
        {
            int result = 0;
            for (int i = 0; i < int.MaxValue; i++)
            {
                string tmp = CreateMD5(input + i);
                if (tmp.StartsWith("000000"))
                {
                    result = i;
                    break;
                }
            }

            return result;
        }

        // Hashing as shown on MSDN & stackoverflow (not my own code)
        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Convert the byte array to hexadecimal string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}