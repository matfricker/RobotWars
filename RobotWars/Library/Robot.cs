using System;

namespace RobotWars.Library
{
    public class Robot
    {
        public Robot(Position position)
        {
            Position = position;
        }

        public Position Position { get; set; }

        public int Penalty { get; set; }

        public void Move(char input)
        {
            Position originalPosition = Position;

            if (input == 'L' || input == 'R')
            {
                // ROTATE
                string newDirection = Direction.GetDirection(Position.Direction, input);
                Position = new Position(Position.X, Position.Y, newDirection);
            }
            else if (input == 'M')
            {
                // MOVE FORWARD
                int X = Position.X;
                int Y = Position.Y;

                switch (Position.Direction)
                {
                    case "N":
                        Y++;
                        break;
                    case "S":
                        Y--;
                        break;
                    case "E":
                        X++;
                        break;
                    case "W":
                        X--;
                        break;
                    default:
                        break;
                }

                Position = new Position(X, Y, Position.Direction);
            }
            else
            {
                throw new Exception("Invalid input");
            }

            if (PenaltyCheck(Position))
            {
                Penalty++;
                Position = originalPosition;
            }
        }

        public bool PenaltyCheck(Position position)
        {
            if (Position.X < 0 || Position.X > 4)
            {
                return true;
            }

            if (Position.Y < 0 || Position.Y > 4)
            {
                return true;
            }

            return false;
        }
    }
}
