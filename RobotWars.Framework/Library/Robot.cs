namespace RobotWars.Library
{
    public class Robot
    {
        public Robot(Position currentPosition)
        {
            CurrentPosition = currentPosition;
        }

        private const int Min = 0;
        private const int Max = 4;

        public Position CurrentPosition { get; set; }

        public int Penalty { get; private set; }

        public void Move(IMovement movement)
        {
            var originalPosition = new Position(CurrentPosition.X, CurrentPosition.Y, CurrentPosition.Direction);
            CurrentPosition = movement.Move(CurrentPosition);
            CurrentPosition = PenaltyCheck(originalPosition);
        }

        public Position PenaltyCheck(Position originalPosition)
        {
            if (CurrentPosition.X < Min || CurrentPosition.X > Max)
            {
                Penalty++;
                return originalPosition;
            }

            if (CurrentPosition.Y < Min || CurrentPosition.Y > Max)
            {
                Penalty++;
                return originalPosition;
            }

            return CurrentPosition;
        }
    }
}
