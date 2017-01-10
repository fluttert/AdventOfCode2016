using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.Challenges.Tests
{
    [TestClass()]
    public class Day20Tests
    {
        [TestMethod()]
        public void Part1Test()
        {
            string[] input = new[] { "5-8", "0-2", "4-7" };
            var actual1 = new Day20().Part1(input, 10);
            Assert.IsTrue(actual1 == 3);
           
        }

        [TestMethod()]
        public void Part2Test()
        {
            string[] input = new[] { "5-8", "0-2", "4-7" };
            var actual1 = new Day20().Part2(input, 9);
            Assert.IsTrue(actual1 == 2);

        }
    }
}