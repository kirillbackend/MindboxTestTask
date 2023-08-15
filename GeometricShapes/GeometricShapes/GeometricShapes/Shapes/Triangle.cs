using System;

namespace GeometricShapes
{
    /// <summary>
    ///  Класс треугольника
    /// </summary>
    public class Triangle : Shape, IRightTriangle
    {
        private readonly double _firstSide;
        private readonly double _secondSide;
        private readonly double _thirdSide;
        private readonly double _halfMeter;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
            _halfMeter = (firstSide + secondSide + thirdSide) / 2;
        }

        /// <summary>
        /// Считаент площадь треугольника
        /// </summary>
        /// <returns> площадь треугольника окургленная до 5 знаков после запятой </returns>
        public override double Area()
        {
            return Math.Round(Math.Sqrt(_halfMeter * (_halfMeter - _firstSide)
                * (_halfMeter - _secondSide) * (_halfMeter - _thirdSide)),5);
        }

        /// <summary>
        /// Проеряет является ли треугольник прямогуголным 
        /// </summary>
        /// <returns></returns>
        public bool IsRectangular() 
            => Math.Pow(_firstSide, 2) + Math.Pow(_secondSide, 2) == Math.Pow(_thirdSide, 2);
    }
}
