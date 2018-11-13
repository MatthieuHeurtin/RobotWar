using NUnit.Framework;
using RobotWars.Event;

namespace RobotWars.Test
{
    public class RobotWarsEngineTest
    {
        [Test]
        public void Should_raise_an_event_for_robot_1_with_its_new_position()
        {
            RobotWarsEngine robotWarsEngine = new RobotWarsEngine();
            robotWarsEngine.StateChanged += UpdateStateRobot1;
            robotWarsEngine.Start(4, 4, 1, 1, "N", "M", 2, 2, "S", "");
        }

        private void UpdateStateRobot1(object sender, StateCHangedEvent e)
        {
            Assert.AreEqual(e.Robot, "Robot1");
            Assert.AreEqual(e.NewPosition.X, 1);
            Assert.AreEqual(e.NewPosition.Y, 2);
            Assert.AreEqual(e.OldPosition.X, 1);
            Assert.AreEqual(e.OldPosition.Y, 1);
            e.Signal.Set();
        }

        [Test]
        public void Should_raise_an_event_for_robot2_with_its_final_position_when_the_command_is_L()
        {
            RobotWarsEngine robotWarsEngine = new RobotWarsEngine();
            robotWarsEngine.StateChanged += UpdateStateRobot2commandL;
            robotWarsEngine.Start(4, 4, 1, 1, "N", "", 2, 2, "S", "L");
        }

        private void UpdateStateRobot2commandL(object sender, StateCHangedEvent e)
        {
            Assert.AreEqual(e.Robot, "Robot2");
            Assert.AreEqual(e.NewPosition.X, 2);
            Assert.AreEqual(e.NewPosition.Y, 2);
            Assert.AreEqual(e.OldPosition.X, 2);
            Assert.AreEqual(e.OldPosition.Y, 2);
            e.Signal.Set();
        }

        [Test]
        public void Should_raise_an_event_for_robot2_with_its_final_position_when_the_command_is_R()
        {
            RobotWarsEngine robotWarsEngine = new RobotWarsEngine();
            robotWarsEngine.StateChanged += UpdateStateRobot2commandR;
            robotWarsEngine.Start(4, 4, 1, 1, "N", "", 2, 2, "E", "R");
        }

        private void UpdateStateRobot2commandR(object sender, StateCHangedEvent e)
        {
            Assert.AreEqual(e.Robot, "Robot2");
            Assert.AreEqual(e.NewPosition.X, 2);
            Assert.AreEqual(e.NewPosition.Y, 2);
            Assert.AreEqual(e.OldPosition.X, 2);
            Assert.AreEqual(e.OldPosition.Y, 2);
            e.Signal.Set();
        }

        [Test]
        public void Should_raise_an_event_for_robot2_with_its_final_position_when_the_command_is_M()
        {
            RobotWarsEngine robotWarsEngine = new RobotWarsEngine();
            robotWarsEngine.StateChanged += UpdateStateRobot2commandM;
            robotWarsEngine.Start(4, 4, 1, 1, "N", "", 2, 2, "W", "M");
        }

        private void UpdateStateRobot2commandM(object sender, StateCHangedEvent e)
        {
            Assert.AreEqual(e.Robot, "Robot2");
            Assert.AreEqual(e.NewPosition.X, 1);
            Assert.AreEqual(e.NewPosition.Y, 2);
            Assert.AreEqual(e.OldPosition.X, 2);
            Assert.AreEqual(e.OldPosition.Y, 2);
            e.Signal.Set();
        }

        [Test]
        public void Should_do_nothing_when_there_is_no_command()
        {
            RobotWarsEngine robotWarsEngine = new RobotWarsEngine();
            robotWarsEngine.Start(4, 4, 1, 1, "N", "", 2, 2, "S", "");
            //no assert, a null pointer exception should be raise it the test fail
        }
    }
}