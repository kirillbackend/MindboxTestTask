using System;

namespace GeometricShapes.Test.ShapesTests
{
    public class TriangleTest
    {
        [Test]
        public void Triangle_Sides122And22And123_Result1340()
        {
            //Arrange
            var _firstSide = 122.0;
            var _secondSide = 22.0;
            var _thirdSide = 123.0;
            var triangle = new Triangle(_firstSide, _secondSide, _thirdSide);

            //Act
            var result = triangle.Area();

            //Assert
            Assert.AreEqual(1340.66921, result);
        }

        [Test]
        public void Triangle_SidesEqualZero_ResultZero()
        {
            //Arrange
            var _firstSide = 0.0;
            var _secondSide = 0.0;
            var _thirdSide = 0.0;
            var triangle = new Triangle(_firstSide, _secondSide, _thirdSide);

            //Act
            var result = triangle.Area();

            //Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Triangle_IsRectangular_True()
        {
            //Arrange
            var _firstSide = 3.0;
            var _secondSide = 4.0;
            var _thirdSide = 5.0;
            var triangle = new Triangle(_firstSide, _secondSide, _thirdSide);

            //Act
            var result = triangle.IsRectangular();

            //Assert
            Assert.AreEqual(true, result);
        }
    }
}
