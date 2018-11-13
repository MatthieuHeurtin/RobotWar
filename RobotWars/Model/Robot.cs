using System;
using System.Collections.Generic;
using System.Drawing;

namespace RobotWars.Model
{
    public class Robot
    {
        private Direction _direction;
        public int Y { get; private set; }
        public int X { get; private set; }
        private readonly Queue<char> _commands;
        public int NbMove { get; private set; }
        public string Name { get; private set; }

        public Robot(string name, int x, int y, Direction direction, string commands)
        {
            Name = name;
            _direction = direction;
            Y = y;
            X = x;
            _commands = new Queue<char>();
            foreach (var c in commands)
            {
                _commands.Enqueue(c);
            }
            NbMove = _commands.Count;
        }

        public Point GetNextMove()
        {
            {
                char c = _commands.Dequeue();
                NbMove--;
                switch (c)
                {
                    case 'L':
                        _direction = GetNewDirection(true);
                        return new Point(X, Y);
                    case 'R':
                        _direction = GetNewDirection(false);
                        return new Point(X, Y);
                    case 'M':
                        return GetNewPosition();
                    default:
                        throw new Exception("Unknown instruction " + c);
                }
            }
        }

        public void Update(Point p)
        {
            X = p.X;
            Y = p.Y;
        }

        private Point GetNewPosition()
        {
            switch (_direction)
            {
                case Direction.North:
                    return new Point(X, Y + 1);
                case Direction.West:
                    return new Point(X - 1, Y);
                case Direction.South:
                    return new Point(X, Y - 1);
                default: //east
                    return new Point(X + 1, Y);
            }
        }

        private Direction GetNewDirection(bool isLeft)
        {
            if (isLeft)
            {
                switch (_direction)
                {
                    case Direction.North:
                        return Direction.West;
                    case Direction.West:
                        return Direction.South;
                    case Direction.South:
                        return Direction.East;
                    default: //East
                        return Direction.North;
                }
            }
            switch (_direction)
            {
                case Direction.North:
                    return Direction.East;
                case Direction.West:
                    return Direction.North;
                case Direction.South:
                    return Direction.West;
                default: //East
                    return Direction.South;
            }
        }
    }
}