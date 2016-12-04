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
    public class C1Tests
    {
        [TestMethod()]
        public void Part1Test()
        {
            Day01 challenge = new Day01();
            Assert.IsTrue(challenge.Part1("R2, L3") == 5);
            Assert.IsTrue(challenge.Part1("R2, R2, R2") == 2);
            Assert.IsTrue(challenge.Part1("R5, L5, R5, R3") == 12);
        }

        [TestMethod()]
        public void Part2Test() {
            Day01 challenge = new Day01();
            Assert.IsTrue(challenge.Part2("R8, R4, R4, R8") == 4);
        }
    }
}