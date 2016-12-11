using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Challenges.Tests
{
    [TestClass()]
    public class Day09Tests
    {
        [TestMethod()]
        public void Day09Part1Test()
        {
            Assert.IsTrue(new Day09().Part1("ADVENT") == "ADVENT");
            Assert.IsTrue(new Day09().Part1("A(1x5)BC") == "ABBBBBC");
            Assert.IsTrue(new Day09().Part1("(3x3)XYZ") == "XYZXYZXYZ");
            Assert.IsTrue(new Day09().Part1("A(2x2)BCD(2x2)EFG") == "ABCBCDEFEFG");
            Assert.IsTrue(new Day09().Part1("(6x1)(1x3)A") == "(1x3)A");
            Assert.IsTrue(new Day09().Part1("X(8x2)(3x3)ABCY") == "X(3x3)ABC(3x3)ABCY");
        }

        [TestMethod()]
        public void Day09Part2Test()
        {
            Assert.IsTrue(new Day09().Part2("ADVENT") == 6);
            Assert.IsTrue(new Day09().Part2("A(1x5)BC") == 7);
            Assert.IsTrue(new Day09().Part2("(3x3)XYZ") == 9);
            Assert.IsTrue(new Day09().Part2("A(8x3)B(1x6)BCD") == 26);
            Assert.IsTrue(new Day09().Part2("X(8x2)(3x3)ABCY") == 20);
            Assert.IsTrue(new Day09().Part2("(27x12)(20x12)(13x14)(7x10)(1x12)A") == 241920);
            Assert.IsTrue(new Day09().Part2("(25x3)(3x3)ABC(2x3)XY(5x2)PQRSTX(18x9)(3x2)TWO(5x7)SEVEN") == 445);
        }
    }
}