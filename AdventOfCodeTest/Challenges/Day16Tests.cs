using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Tests
{
    [TestClass()]
    public class Day16Tests
    {
        [TestMethod()]
        public void Part1Test()
        {
            string actual = new Day16().Part1(new string[] { "10000" }, 20);

            Assert.IsTrue(actual == "01100");
        }
    }
}