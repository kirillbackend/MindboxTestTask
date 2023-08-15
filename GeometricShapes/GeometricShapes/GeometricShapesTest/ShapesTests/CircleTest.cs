using GeometricShapes;

namespace GeometricShapes.Test.ShapesTests
{
    public class CircleTest
    {

        [Test]
        public void Circle_RadiusEqual10_Result314()
        {
            //Arrange
            var radius = 10.0;
            var circle = new Circle(radius);

            //Act
            var result = circle.Area();

            //Assert
            Assert.AreEqual(314.15927, result);
        }

        [Test]
        public void Circle_RadiusEqualZero_ResultZero()
        {
            //Arrange
            var radius = 0.0;
            var circle = new Circle(radius);

            //Act
            var result = circle.Area();

            //Assert
            Assert.AreEqual(0, result);
        }
    }
}