using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.Challenges.Tests
{
    [TestClass()]
    public class Day07Tests
    {
        [TestMethod()]
        public void Day07Part1Test()
        {
            string[] input = new[] {
                "abba[mnop]qrst",
                "abcd[bddb]xyyx",
                "xyyx[bddb]",
                "aaaa[qwer]tyui",
                "ioxxoj[asdfgh]zxcvbn",
                "ij[asdfgh]zxcvbnoxxo",
                "ij[oxxo]zxcvbn"
            };

            Assert.IsTrue(new Day07().Part1(input) == 3);
        }

        [TestMethod]
        public void Day07Part21Test()
        {
            string[] input = new[] {
                "aba[bab]xyz",
                "xyx[xyx]xyx",
                "aaa[kek]eke",
                "zazbz[bzb]cdb",
                "aaa[kek]eke[kek]eke",
            };

            Assert.IsTrue(new Day07().Part2(input) == 4);
        }
    }
}