using System;
using System.Drawing;
using System.Threading;

namespace RobotWars.Event
{
    public class StateCHangedEvent : EventArgs
    {
        public StateCHangedEvent(Point position, string robot, AutoResetEvent signal, Point oldPosition)
        {
            NewPosition = position;
            Robot = robot;
            Signal = signal;
            OldPosition = oldPosition;
        }

        public AutoResetEvent Signal { get; private set; }

        public Point NewPosition { get; private set; }

        public string Robot { get; private set; }

        public Point OldPosition { get; private set; }

    }

}