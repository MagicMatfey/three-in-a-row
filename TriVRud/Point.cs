namespace TriVRud
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int y = 0, int x = 0)
        {
            Y = y;
            X = x;
            
        }

        public Point(Point point)
        {
            X = point.X;
            Y = point.Y;
        }

        public override bool Equals(object? obj)
        {
            if(obj  is Point other)
            {
                return X == other.X && Y == other.Y;
            }
            return false;
        }
    }
}