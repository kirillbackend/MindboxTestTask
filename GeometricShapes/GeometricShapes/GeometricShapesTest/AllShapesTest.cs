
namespace GeometricShapes.Test
{
    public class AllShapesTest
    {
        [Test]
        public void AllShapes_OneVariable_AreaCircle()
        {
            //Arrange
            var radius = 75.0;
            var circle = new Circle(radius);

            //Act
            var result = circle.Area();

            //Assert
            Assert.AreEqual(17671.45868, result);
        }

        [Test]
        public void AllShapes_ThreeVariables_AreaTriangle()
        {
            //Arrange
            var _firstSide = 11.0;
            var _secondSide = 21.0;
            var _thirdSide = 17.0;
            var triangle = new Triangle(_firstSide, _secondSide, _thirdSide);

            //Act
            var result = triangle.Area();

            //Assert
            Assert.AreEqual(93.17826, result);
        }
    }
}
