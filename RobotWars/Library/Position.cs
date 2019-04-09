namespace RobotWars
{
    public class Position
    {
        public Position() { }

        public Position(int x, int y, string direction)
        {
            X = x;
            Y = y;
            Direction = direction;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public string Direction { get; set; }
    }
}
