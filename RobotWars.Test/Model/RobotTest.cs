using System.Drawing;
using NUnit.Framework;
using RobotWars.Model;

namespace RobotWars.Test.Model
{
    public class RobotTest
    {

        [Test]
        public void Should_not_change_the_position_when_the_command_is_left()
        {
            Robot robot = new Robot("robot", 4, 5, Direction.East, "L");
            Point actual = robot.GetNextMove();
            Assert.AreEqual(actual.X, 4);
            Assert.AreEqual(actual.Y, 5);
        }

        [Test]
        public void Should_not_change_the_position_when_the_command_is_right()
        {
            Robot robot = new Robot("robot", 4, 5, Direction.East, "R");
            Point actual = robot.GetNextMove();
            Assert.AreEqual(actual.X, 4);
            Assert.AreEqual(actual.Y, 5);
        }

        [Test]
        public void Should_change_the_position_when_the_command_is_move_and_direction_east()
        {
            Robot robot = new Robot("robot", 4, 5, Direction.East, "M");
            Point actual = robot.GetNextMove();
            Assert.AreEqual(actual.X, 5);
            Assert.AreEqual(actual.Y, 5);
        }

        [Test]
        public void Should_change_the_position_when_the_command_is_move_and_direction_west()
        {
            Robot robot = new Robot("robot", 4, 5, Direction.West, "M");
            Point actual = robot.GetNextMove();
            Assert.AreEqual(actual.X, 3);
            Assert.AreEqual(actual.Y, 5);
        }

        [Test]
        public void Should_change_the_position_when_the_command_is_move_and_direction_north()
        {
            Robot robot = new Robot("robot", 4, 5, Direction.North, "M");
            Point actual = robot.GetNextMove();
            Assert.AreEqual(actual.X, 4);
            Assert.AreEqual(actual.Y, 6);
        }

        [Test]
        public void Should_change_the_position_when_the_command_is_move_and_direction_south()
        {
            Robot robot = new Robot("robot", 4, 5, Direction.South, "M");
            Point actual = robot.GetNextMove();
            Assert.AreEqual(actual.X, 4);
            Assert.AreEqual(actual.Y, 4);
        }

        [Test]
        public void Should_not_change_the_position_when_the_command_is_left_and_direction_south()
        {
            Robot robot = new Robot("robot", 4, 5, Direction.South, "L");
            Point actual = robot.GetNextMove();
            Assert.AreEqual(actual.X, 4);
            Assert.AreEqual(actual.Y, 5);
        }

        [Test]
        public void Should_not_change_the_position_when_the_command_is_right_and_direction_south()
        {
            Robot robot = new Robot("robot", 4, 5, Direction.South, "R");
            Point actual = robot.GetNextMove();
            Assert.AreEqual(actual.X, 4);
            Assert.AreEqual(actual.Y, 5);
        }

        [Test]
        public void Should_update_position()
        {
            Robot robot = new Robot("robot", 4, 5, Direction.South, "M");
            robot.Update(new Point(5, 6));
            Assert.AreEqual(robot.X, 5);
            Assert.AreEqual(robot.Y, 6);
        }
    }
}


