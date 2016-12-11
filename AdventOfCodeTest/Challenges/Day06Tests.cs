using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.Challenges.Tests
{
    [TestClass()]
    public class Day06Tests
    {
        [TestMethod()]
        public void Day06Part1Test()
        {
            string[] input = new[] {
                "eedadn","drvtee","eandsr","raavrd","atevrs","tsrnev","sdttsa","rasrtv","nssdts","ntnada","svetve","tesnvt","vntsnd","vrdear","dvrsen","enarar"
            };

            Assert.IsTrue(new Day06().Part1(input) == "easter");
        }

        [TestMethod()]
        public void Day06Part2Test()
        {
            string[] input = new[] {
                "eedadn","drvtee","eandsr","raavrd","atevrs","tsrnev","sdttsa","rasrtv","nssdts","ntnada","svetve","tesnvt","vntsnd","vrdear","dvrsen","enarar"
            };

            Assert.IsTrue(new Day06().Part2(input) == "advent");
        }
    }
}