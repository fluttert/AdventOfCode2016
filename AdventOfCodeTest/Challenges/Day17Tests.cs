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
    public class Day17Tests
    {
        [TestMethod()]
        public void Part1Test()
        {
            Day17 day17 = new Day17();
            string actualTest1 = day17.Part1(new string[] { "ihgpwlah" });
            string actualTest2 = day17.Part1(new string[] { "kglvqrro" });
            string actualTest3 = day17.Part1(new string[] { "ulqzkmiv" });
            Assert.IsTrue(actualTest1 == "DDRRRD");
            Assert.IsTrue(actualTest2 == "DDUDRLRRUDRD");
            Assert.IsTrue(actualTest3 == "DRURDRUDDLLDLUURRDULRLDUUDDDRR");
        }

        [TestMethod()]
        public void Part2Test()
        {
            Day17 day17 = new Day17();
            string actualTest1 = day17.Part2(new string[] { "ihgpwlah" });
            string actualTest2 = day17.Part2(new string[] { "kglvqrro" });
            string actualTest3 = day17.Part2(new string[] { "ulqzkmiv" });
            Assert.IsTrue(actualTest1 == "370");
            Assert.IsTrue(actualTest2 == "492");
            Assert.IsTrue(actualTest3 == "830");
        }
    }
}