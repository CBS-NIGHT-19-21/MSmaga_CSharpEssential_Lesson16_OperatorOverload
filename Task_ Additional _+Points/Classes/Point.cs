namespace Task_Additional_Points
{
    class Point
    {
        private readonly double _x;
        private readonly double _y;
        private readonly double _z;

        public double X { get { return _x; } }
        public double Y { get { return _y; } }
        public double Z { get { return _z; } }

        public Point(double x, double y, double z)
        {
            _x = x;
            _y = y;
            _z = z;
        }
        public static Point operator +(Point point1, Point point2) =>
             new (point1.X + point2.X, point1.Y + point2.Y, point1.Z + point2.Z);
        public static Point operator -(Point point1, Point point2) =>
             new (point2.X - point1.X, point2.Y - point1.Y, point2.Z - point1.Z);
        public static Point operator *(Point point1, Point point2) =>
             new (point1.X * point2.X, point1.Y * point2.Y, point1.Z * point2.Z);
        public static Point operator /(Point point1, Point point2) =>
             new (point1.X / point2.X, point1.Y / point2.Y, point2.Z / point2.Z);

    }
}
