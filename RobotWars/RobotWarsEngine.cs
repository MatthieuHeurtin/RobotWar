using System;
using RobotWars.Event;
using RobotWars.Model;
using System.Drawing;
using System.Threading;

namespace RobotWars
{
    public class RobotWarsEngine : IRobotWarsEngine
    {
        public event EventHandler<StateCHangedEvent> StateChanged;
        private readonly AutoResetEvent _signal = new AutoResetEvent(false);

        public void Start(int height, int width,
            int x1, int y1, string direction1, string commands1,
            int x2, int y2, string direction2, string commands2)
        {
            Map map = new Map(height, width);
            Robot robot1 = new Robot("Robot1", x1, y1, DirectionConverter.ConvertToDirection(direction1), commands1);
            Robot robot2 = new Robot("Robot2", x2, y2, DirectionConverter.ConvertToDirection(direction2), commands2);

            while (robot1.NbMove > 0 || robot2.NbMove > 0)
            {
                RobotTurn(robot1, map);
                //TODO raise an event when there is a collision, so the user can see it
                RobotTurn(robot2, map);
            }
        }

        private void RobotTurn(Robot robot, Map map)
        {
            if (robot.NbMove > 0)
            {
                Point p = robot.GetNextMove();
                if (map.IsOnTheMap(p.X, p.Y))
                //TODO raise an event when the robot is out of the map, so the user can see it
                {
                    RaiseStateChangedEvent(p, robot.Name, new Point(robot.X, robot.Y));
                    robot.Update(p);
                    _signal.WaitOne();
                }
            }
        }

        private void RaiseStateChangedEvent(Point newPOsition, string robot, Point oldPosition)
        {
            StateChanged?.Invoke(this, new StateCHangedEvent(newPOsition, robot, _signal, oldPosition));
        }
    }
}