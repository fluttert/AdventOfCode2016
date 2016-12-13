using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.Challenges.Tests
{
    [TestClass()]
    public class Day13Tests
    {
        private Day13 day13;

        [TestInitialize]
        public void TestInitialize()
        {
            day13 = new Day13();
        }

        [TestMethod()]
        public void CreateMazeTest()
        {
            char[][] mazeActual = day13.CreateMaze(10, 7, 10);
            char[][] mazeExpected = new char[7][];
            mazeExpected[0] = ".#.####.##".ToCharArray();
            mazeExpected[1] = "..#..#...#".ToCharArray();
            mazeExpected[2] = "#....##...".ToCharArray();
            mazeExpected[3] = "###.#.###.".ToCharArray();
            mazeExpected[4] = ".##..#..#.".ToCharArray();
            mazeExpected[5] = "..##....#.".ToCharArray();
            mazeExpected[6] = "#...##.###".ToCharArray();
            for (int i = 0; i < mazeExpected.Length; i++) {
                CollectionAssert.AreEqual(mazeExpected[i], mazeActual[i]);
            }
        }

        [TestMethod()]
        public void Day13IsBinarySumEvenTest()
        {
            Assert.IsTrue(day13.IsBinarySumEven(0));  // 000
            Assert.IsFalse(day13.IsBinarySumEven(1)); // 001
            Assert.IsFalse(day13.IsBinarySumEven(2)); // 010
            Assert.IsTrue(day13.IsBinarySumEven(3));  // 011
            Assert.IsFalse(day13.IsBinarySumEven(4)); // 100
            Assert.IsTrue(day13.IsBinarySumEven(5));  // 101
            Assert.IsTrue(day13.IsBinarySumEven(6));  // 110
            Assert.IsFalse(day13.IsBinarySumEven(7)); // 111
            Assert.IsFalse(day13.IsBinarySumEven(8)); // 1000
            Assert.IsTrue(day13.IsBinarySumEven(9));  // 1001
        }
    }
}