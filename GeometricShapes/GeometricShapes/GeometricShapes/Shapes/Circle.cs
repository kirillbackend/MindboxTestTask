using System;

namespace GeometricShapes
{
    /// <summary>
    ///  Класс окружности
    /// </summary>
    public class Circle : Shape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        /// <summary>
        /// Считаент площадь окуржности
        /// </summary>
        /// <returns> площадь окружности окургленная до 5 знаков после запятой</returns>
        public override double Area() => 
            Math.Round(Math.PI * Math.Pow(_radius, 2),5);
    }
}
