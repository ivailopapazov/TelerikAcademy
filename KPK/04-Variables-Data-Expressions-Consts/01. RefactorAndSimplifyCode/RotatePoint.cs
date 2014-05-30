namespace PointRotation
{
    using System;

    class PointRotation
    {
        public static void Main(string[] args)
        {

        }

        public static Point GetRotatedPoint(Point point, double rotationAngle)
        {
            double rotationAngleCos = Math.Abs(Math.Cos(rotationAngle));
            double rotationAngleSin = Math.Abs(Math.Sin(rotationAngle));
            double rotatedPointPositionX = rotationAngleCos * point.PositionX + rotationAngleSin * point.PositionY;
            double rotatedPointPositionY = rotationAngleSin * point.PositionX + rotationAngleCos * point.PositionY;
            Point rotatedPoint = new Point(rotatedPointPositionX, rotatedPointPositionY);

            return rotatedPoint;
        }
    }
}