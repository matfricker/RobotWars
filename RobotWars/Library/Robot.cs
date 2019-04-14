namespace RobotWars.Library
{
    public class Robot
    {
        const int MIN = 0;

        const int MAX = 4;

        public char Input { get; set; }

        public Position Position { get; set; }

        public int Penalty { get; set; }

        public void Move(IMovement movement)
        {
            Position originalPosition = Position;
            Position = movement.Move(Position);
            Position = PenaltyCheck(originalPosition);
        }

        public Position PenaltyCheck(Position originalPosition)
        {
            if (Position.X < MIN || Position.X > MAX)
            {
                Penalty++;
                return originalPosition;
            }

            if (Position.Y < MIN || Position.Y > MAX)
            {
                Penalty++;
                return originalPosition;
            }

            return Position;
        }
    }
}
