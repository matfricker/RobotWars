namespace RobotWars.Library
{
    public class MoveForward : IMovement
    {
        public Position Move(Position position)
        {
            // MOVE FORWARD
            int X = position.X;
            int Y = position.Y;

            switch (position.Direction)
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

            return new Position(X, Y, position.Direction);
        }
    }
}
