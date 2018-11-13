using NUnit.Framework;
using RobotWars.Model;

namespace RobotWars.Test.Model

{

    public class MapTest
    {
        [TestCase(-1, 3)]
        [TestCase(4, 3)]
        [TestCase(2, -2)]
        [TestCase(2, 5)]
        public void Should_return_false_when_the_point_is_not_on_the_map(int x, int y)
        {
            Map map = new Map(3, 3);
            bool actual = map.IsOnTheMap(x, y);
            Assert.AreEqual(actual, false);
        }

        [TestCase(0, 0)]
        [TestCase(1, 0)]
        [TestCase(2, 0)]
        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(0, 2)]
        [TestCase(1, 2)]
        [TestCase(2, 2)]
        public void Should_return_true_when_the_point_is_on_the_map(int x, int y)
        {
            Map map = new Map(3, 3);
            bool actual = map.IsOnTheMap(x, y);
            Assert.AreEqual(actual, true);
        }
    }
}


