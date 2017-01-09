using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.Challenges.Tests
{
    [TestClass()]
    public class DiscTests
    {
        [TestMethod()]
        public void DiscTest2positions()
        {
            Disc d = new Disc(2, 0);
            Assert.IsTrue(d.AddTime(0) == 0);

            Assert.IsTrue(d.AddTime(1) == 1);

            Assert.IsTrue(d.AddTime(2) == 0);

            Assert.IsTrue(d.AddTime(3) == 1);
        }
    }
}