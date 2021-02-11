namespace RobotWars.Library
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

        public int IncrementX()
        {
            return X++;
        }
        
        public int IncrementY()
        {
            return Y++;
        }
        
        public int DecrementX()
        {
            return X--;
        }
        
        public int DecrementY()
        {
            return Y--;
        }

        public int X { get; private set; }
        public int Y { get; private set; }
        public string Direction { get; }
    }
}
