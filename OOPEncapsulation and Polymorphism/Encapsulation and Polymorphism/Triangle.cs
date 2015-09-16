using System;

namespace Shapes
{
    public class Triangle : BasicShape
    {
        private double includedAngle;

        public Triangle(double width, double height, double includedAngle)
            :base(width, height)
        {
            this.IncludedAngle = includedAngle;
        }

        public double IncludedAngle
        {
            get { return this.includedAngle; }
            set
            {
                if (value < 0 || value > 360)
                {
                    throw new ArgumentOutOfRangeException("The included angle accepts only values between 0 and 360 deg");
                }
                this.includedAngle = value;
            }
        }

        public override double CalculateArea() 
        {
            return this.Width * this.Height;
        }

        public override double CalculatePerimeter()
        {
            return (this.Width + this.Height) * 2;
        }   
    }
}
