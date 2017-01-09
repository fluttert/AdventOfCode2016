using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.Challenges.Tests
{
    [TestClass()]
    public class Day15Tests
    {
        private Day15 day15;

        [TestInitialize]
        public void TestInitialize()
        {
            day15 = new Day15();
        }

        [TestMethod()]
        public void Part1Test()
        {
            string[] input = new[] {
                "Disc #1 has 5 positions; at time=0, it is at position 4.",
                "Disc #2 has 2 positions; at time=0, it is at position 1."
            };
            int actual = day15.Part1(input);


            Assert.IsTrue(actual == 5);
        }
    }
}