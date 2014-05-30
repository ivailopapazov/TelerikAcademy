namespace PointRotation
{
    using System;

    //Reason for naming the class "Point" is the formula from the GetRotatedPoint() method:
    //http://en.wikipedia.org/wiki/Rotation_%28mathematics%29
    public class Point
    {
        private double positionX;
        private double positionY;

        public double PositionX
        {
            get
            {
                return this.positionX;
            }
            set
            {
                this.positionX = value;
            }
        }

        public double PositionY 
        {
            get
            {
                return this.positionY;
            }
            set
            {
                this.positionY = value;
            }
        }

        public Point(double positionX, double positionY)
        {
            this.PositionX = positionX;
            this.PositionY = positionY;
        }
    }
}
