﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Tests
{
    [TestClass()]
    public class Day04Tests
    {
        [TestMethod()]
        public void Part1Test()
        {
            string[] input = new[] {
                "aaaaa-bbb-z-y-x-123[abxyz]",
                "a-b-c-d-e-f-g-h-987[abcde]",
                "a-b-c-d-e-f-g-h-987[acbde]",
                "not-a-real-room-404[oarel]",
                "totally-real-room-200[decoy]"
            };
            Assert.IsTrue(new Day04().Part1(input) == 1514);
        }
    }
}