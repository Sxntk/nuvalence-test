namespace Shapes.Model.Tests
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void CreatingRectangle_WithPositiveCoordinates()
        {
            // Act
            Rectangle shape = new(10, 12, 20, 22);

            // Assert
            Assert.AreEqual(10, shape.StartPointX, "StartPointX");
            Assert.AreEqual(12, shape.StartPointY, "StartPointY");
            Assert.AreEqual(20, shape.EndPointX, "EndPointX");
            Assert.AreEqual(22, shape.EndPointY, "EndPointY");
            Assert.AreEqual(10, shape.Width, "Width");
            Assert.AreEqual(10, shape.Height, "Height");
        }

        [TestMethod]
        public void CreatingRectangle_WithNegativeCoordinates()
        {
            // Act
            Rectangle shape = new(-10, -12, -20, -22);

            // Assert
            Assert.AreEqual(-10, shape.StartPointX, "StartPointX");
            Assert.AreEqual(-12, shape.StartPointY, "StartPointY");
            Assert.AreEqual(-20, shape.EndPointX, "EndPointX");
            Assert.AreEqual(-22, shape.EndPointY, "EndPointY");
            Assert.AreEqual(10, shape.Width, "Width");
            Assert.AreEqual(10, shape.Height, "Height");
        }

        [TestMethod]
        public void CreatingRectangle_WithMixedCoordinates()
        {
            // Act
            Rectangle shape = new(10, 12, -20, -22);

            // Assert
            Assert.AreEqual(10, shape.StartPointX, "StartPointX");
            Assert.AreEqual(12, shape.StartPointY, "StartPointY");
            Assert.AreEqual(-20, shape.EndPointX, "EndPointX");
            Assert.AreEqual(-22, shape.EndPointY, "EndPointY");
            Assert.AreEqual(30, shape.Width, "Width");
            Assert.AreEqual(34, shape.Height, "Height");
        }

        [TestMethod]
        public void CreatingRectangle_InitialPointBiggerThanEndpoint()
        {
            // Act
            Rectangle shape = new(20, 15, 10, 10);

            // Assert
            Assert.AreEqual(20, shape.StartPointX, "StartPointX");
            Assert.AreEqual(15, shape.StartPointY, "StartPointY");
            Assert.AreEqual(10, shape.EndPointX, "EndPointX");
            Assert.AreEqual(10, shape.EndPointY, "EndPointY");
            Assert.AreEqual(10, shape.Width, "Width");
            Assert.AreEqual(5, shape.Height, "Height");
        }
    }
}
