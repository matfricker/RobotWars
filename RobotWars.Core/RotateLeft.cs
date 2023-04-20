namespace RobotWars.Core
{
    public class RotateLeft : IMovement
    {
        public Position Move(Position position)
        {
            // ROTATE
            var newDirection = Direction.GetDirection(position.Direction, MovementDirection.Left);
            return new Position(position.X, position.Y, newDirection);
        }
    }
}