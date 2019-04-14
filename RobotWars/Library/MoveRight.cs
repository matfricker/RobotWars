namespace RobotWars.Library
{
    public class MoveRight : IMovement
    {
        public Position Move(Position position)
        {
            // ROTATE
            var newDirection = Direction.GetDirection(position.Direction, MovementDirection.Right);
            return new Position(position.X, position.Y, newDirection);
        }
    }
}