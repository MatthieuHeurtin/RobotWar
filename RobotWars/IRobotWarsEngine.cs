using RobotWars.Event;
using System;

namespace RobotWars
{
    public interface IRobotWarsEngine
    {
        void Start(int height, int width,
            int x1, int y1, string direction1, string commands1,
            int x2, int y2, string direction2, string commands2);

        event EventHandler<StateCHangedEvent> StateChanged;
    }
}
