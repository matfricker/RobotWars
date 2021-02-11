namespace RobotWars.Library
{
    public class MoveForward : IMovement
    {
        public Position Move(Position position)
        {
            // MOVE FORWARD
            switch (position.Direction)
            {
                case "N":
                    position.IncrementY();
                    break;
                case "S":
                    position.DecrementY();
                    break;
                case "E":
                    position.IncrementX();
                    break;
                case "W":
                    position.DecrementX();
                    break;
            }

            return position;
        }
    }
}
