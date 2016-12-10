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
        public void Part1Test()
        {
            Assert.IsTrue(new Day09().Part1("ADVENT") == "ADVENT");
            Assert.IsTrue(new Day09().Part1("A(1x5)BC") == "ABBBBBC");
            Assert.IsTrue(new Day09().Part1("(3x3)XYZ") == "XYZXYZXYZ");
            Assert.IsTrue(new Day09().Part1("A(2x2)BCD(2x2)EFG") == "ABCBCDEFEFG");
            Assert.IsTrue(new Day09().Part1("(6x1)(1x3)A") == "(1x3)A");
            Assert.IsTrue(new Day09().Part1("X(8x2)(3x3)ABCY") == "X(3x3)ABC(3x3)ABCY");
        }
    }
}