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
    public class Day18Tests
    {
        [TestMethod()]
        public void Part1Test()
        {
            int actual = new Day18().Part1(new string[] { ".^^.^.^^^^"}, 10);
            Assert.IsTrue(actual == 38);
        }
    }
}