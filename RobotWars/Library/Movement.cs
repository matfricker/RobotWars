namespace RobotWars
{
    public class Movement
    {
        public static Position Move(Position currentPosition, string input, out bool hasPenalty)
        {
            Position newPosition = currentPosition;

            if (input == "L" || input == "R")
            {
                // ROTATE
                string newDirection = Direction.GetDirection(currentPosition.Direction, input);
                newPosition = new Position(currentPosition.X, currentPosition.Y, newDirection);
            }
            else if (input == "M")
            {
                // MOVE FORWARD
                int X = currentPosition.X;
                int Y = currentPosition.Y;

                switch (currentPosition.Direction)
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

                newPosition = new Position(X, Y, currentPosition.Direction);
            }

            if (Penalty.Check(newPosition))
            {
                hasPenalty = true;
                newPosition = currentPosition;
            }
            else
            {
                hasPenalty = false;
            }

            return newPosition;
        }

    }
}
