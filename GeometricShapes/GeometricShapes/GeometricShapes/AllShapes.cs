using System;

namespace GeometricShapes
{
    public class AllShapes
    {
        public double GetArea(double _radius) 
            => Math.Round(Math.PI* Math.Pow(_radius, 2),5);

        public double GetArea(double firstSide, double secondSide, double thirdSide)
        {
            var _halfMeter = (firstSide + secondSide + thirdSide) / 2;
            return Math.Round(Math.Sqrt(_halfMeter * (_halfMeter - firstSide)
                * (_halfMeter - secondSide) * (_halfMeter - thirdSide)), 5);
        }
    }
}
