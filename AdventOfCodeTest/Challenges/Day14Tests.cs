using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.Challenges.Tests
{
    [TestClass()]
    public class Day14Tests
    {
        [TestMethod()]
        public void Part1Test()
        {
            var input = new string[] { "abc" };
            Assert.IsTrue(new Day14().Part1(input) == 22728);
        }

        [TestMethod()]
        public void ConsecutiveCharsTest()
        {
            var day14 = new Day14();

            Assert.IsTrue(day14.ConsecutiveChars("aa", 2) == "a");
            Assert.IsTrue(day14.ConsecutiveChars("aa", 3) == "");
            Assert.IsTrue(day14.ConsecutiveChars("aaaa", 3) == "a");
            Assert.IsTrue(day14.ConsecutiveChars("aaabbb", 3) == "ab");
            Assert.IsTrue(day14.ConsecutiveChars("aaabbb", 4) == "");
            Assert.IsTrue(day14.ConsecutiveChars("cc38887a5", 3) == "8");
            Assert.IsTrue(day14.ConsecutiveChars("cc3888", 3) == "8");
            Assert.IsTrue(day14.ConsecutiveChars("8887a5", 3) == "8");
            Assert.IsTrue(day14.ConsecutiveChars("cc388887a5", 3) == "8");
            Assert.IsTrue(day14.ConsecutiveChars("7EBC28B434040502706188888B77777D", 5) == "87");
        }
    }
}