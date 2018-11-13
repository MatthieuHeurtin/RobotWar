using RobotWars.Model;
using System;

namespace RobotWars
{
    public class DirectionConverter
    {
        public static Direction ConvertToDirection(string directionString)
        {
            switch (directionString)
            {
                case "N":
                    return Direction.North;
                case "S":
                    return Direction.South;
                case "E":
                    return Direction.East;
                case "W":
                    return Direction.West;
                default:
                    throw new Exception(string.Concat("Unknonw direction {0}", directionString));
            }
        }
    }
}
