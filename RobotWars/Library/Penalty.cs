namespace RobotWars
{
    public class Penalty
    {
        public static bool Check(Position position)
        {
            if (position.X < 0 || position.X > 4)
            {
                return true;
            }

            if (position.Y < 0 || position.Y > 4)
            {
                return true;
            }

            return false;
        }
    }
}
