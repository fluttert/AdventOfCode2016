using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.Challenges.Tests
{
    [TestClass()]
    public class Day10Tests
    {
        [TestMethod()]
        public void Day10Part1Test()
        {
            string[] input = new[]{
                "value 5 goes to bot 2",
                "bot 2 gives low to bot 1 and high to bot 0",
                "value 3 goes to bot 1",
                "bot 1 gives low to output 1 and high to bot 0",
                "bot 0 gives low to output 2 and high to output 0",
                "value 2 goes to bot 2" };
            Assert.IsTrue(new Day10().Part1(input, 2, 5) == 2);
            Assert.IsTrue(new Day10().Part1(input, 3, 5) == 0);
            Assert.IsTrue(new Day10().Part1(input, 2, 3) == 1);
        }
    }
}