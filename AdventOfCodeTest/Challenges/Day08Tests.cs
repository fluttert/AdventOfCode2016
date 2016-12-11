using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.Challenges.Tests
{
    [TestClass()]
    public class Day08Tests
    {
        private Day08 part1;

        [TestInitialize]
        public void TestInitialize()
        {
            part1 = new Day08();
        }

        [TestMethod()]
        public void Day08Part1PrintScreen()
        {
            string[] input = new[] { "" };
            part1.Part1(input, 3, 4);
            var expected = new[] { "...", "...", "...", "..." };
            CollectionAssert.AreEqual(expected, part1.PrintScreen(part1.screen));
        }

        [TestMethod()]
        public void Day08Part1LitRectangle()
        {
            string[] input = new[] { "rect 2x2" };
            part1.Part1(input, 3, 4);
            var expected = new[] { "##.", "##.", "...", "..." };
            CollectionAssert.AreEqual(expected, part1.PrintScreen(part1.screen));
        }

        [TestMethod()]
        public void Day08Part1RotateColumn()
        {
            string[] input = new[] { "rect 2x2", "rotate column x=1 by 1", "rotate column x=1 by 2" };
            part1.Part1(input, 3, 4);
            var expected = new[] { "##.", "#..", "...", ".#." };
            CollectionAssert.AreEqual(expected, part1.PrintScreen(part1.screen));
        }

        [TestMethod()]
        public void Day08Part1RotateRow()
        {
            string[] input = new[] { "rect 2x1", "rotate row y=0 by 5", "rotate row y=0 by 5" };
            part1.Part1(input, 7, 1);
            var expected = new[] { "...##.." };
            CollectionAssert.AreEqual(expected, part1.PrintScreen(part1.screen));
        }

        [TestMethod()]
        public void Day08Part1PixelsLit()
        {
            string[] input = new[] { "rect 2x2", "rotate row y=0 by 1", "rotate column x=1 by 1", "rect 2x2" };
            Assert.IsTrue(part1.Part1(input, 3, 3) == 6);
        }

        [TestMethod()]
        public void Day08Part1TotalTest()
        {
            string[] input = new[] {
                "rect 3x2",
                "rotate column x=1 by 1",
                "rotate row y=0 by 4",
                "rotate column x=1 by 1" };
            Assert.IsTrue(part1.Part1(input, 7, 3) == 6);
        }
    }
}