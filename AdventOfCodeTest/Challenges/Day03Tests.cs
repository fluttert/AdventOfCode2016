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
    public class Day3Tests
    {
        [TestMethod()]
        public void Day03Part1Test()
        {
            string[] input = { "5 10 25", "25 10 5", "5 10 12", " 10 15 5" };
            Assert.IsTrue(new Day03().Part1(input) == 1);
        }
    }
}