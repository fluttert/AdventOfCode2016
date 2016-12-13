using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.Challenges.Tests
{
    [TestClass()]
    public class Day13Tests
    {
        [TestMethod()]
        public void CreateMazeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void Day13IsBinarySumEvenTest()
        {
            Assert.IsTrue(new Day13().IsBinarySumEven(0));  // 000
            Assert.IsFalse(new Day13().IsBinarySumEven(1)); // 001
            Assert.IsFalse(new Day13().IsBinarySumEven(2)); // 010
            Assert.IsTrue(new Day13().IsBinarySumEven(3));  // 011
            Assert.IsFalse(new Day13().IsBinarySumEven(4)); // 100
            Assert.IsTrue(new Day13().IsBinarySumEven(5));  // 101
            Assert.IsTrue(new Day13().IsBinarySumEven(6));  // 110
            Assert.IsFalse(new Day13().IsBinarySumEven(7)); // 111
            Assert.IsFalse(new Day13().IsBinarySumEven(8)); // 1000
            Assert.IsTrue(new Day13().IsBinarySumEven(9));  // 1001
        }
    }
}