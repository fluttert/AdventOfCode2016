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
    public class Day2Tests
    {
        [TestMethod()]
        public void Day02Part1Test()
        {
            string[] input = { "ULL", "RRDDD", "LURDL", "UUUUD" };
            Assert.IsTrue(new Day02().Part1(input) == "1985");
        }

        [TestMethod()]
        public void Day02Part2Test() {
            string[] input = { "ULL", "RRDDD", "LURDL", "UUUUD" };
            Assert.IsTrue(new Day02().Part2(input) == "5DB3");
        }
    }
}