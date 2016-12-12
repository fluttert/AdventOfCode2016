using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.Challenges.Tests
{
    [TestClass()]
    public class Day12Tests
    {
        [TestMethod()]
        public void Day12Part1Test()
        {
            string[] input = new[] {
                "cpy 41 a","inc a","inc a","dec a","jnz a 2","dec a"
            };
            Assert.IsTrue(new Day12().Part1(input) == 42);
            string[] input1 = new[] {
                "cpy 2 a","inc a","dec a","jnz a -1","dec a"
            };
            Assert.IsTrue(new Day12().Part1(input1) == -1);

        }
    }
}