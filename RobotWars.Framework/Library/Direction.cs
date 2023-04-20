namespace RobotWars.Library
{
    public class Direction
    {
        public static string GetDirection(string previousDirection, MovementDirection rotation)
        {
            switch (rotation)
            {
                case MovementDirection.Left:
                    switch (previousDirection)
                    {
                        case "N":
                            return "W";
                        case "S":
                            return "E";
                        case "E":
                            return "N";
                        case "W":
                            return "S";
                        default:
                            return "invalid direction";
                    }
                case MovementDirection.Right:
                    switch (previousDirection)
                    {
                        case "N":
                            return "E";
                        case "S":
                            return "W";
                        case "E":
                            return "S";
                        case "W":
                            return "N";
                        default:
                            return "invalid direction";
                    }
                default:
                    return "invalid rotation";
            }
        }
    }
}
