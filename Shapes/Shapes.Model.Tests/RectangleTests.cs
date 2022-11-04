namespace Shapes.Model.Tests
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void Having()
        {
            // Arrange

            // Act
            Rectangle shape = new Rectangle(10, 12, 20, 22);

            // Assert
            Assert.AreEqual(10, shape.StartPointX, "StartPointX");
            Assert.AreEqual(12, shape.StartPointY, "StartPointY");
            Assert.AreEqual(20, shape.EndPointX, "EndPointX");
            Assert.AreEqual(22, shape.EndPointY, "EndPointY");
            Assert.AreEqual(10, shape.Width, "Width");
            Assert.AreEqual(10, shape.Height, "Height");
        }
    }
}
