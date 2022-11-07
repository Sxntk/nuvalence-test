using Shapes.Model;

namespace Shapes.Services.Tests
{
    [TestClass]
    public class AdjacencyServiceTests
    {
        [TestMethod]
        public void SegmentPartialAdjacent_Right1_WithLeft2()
        {
            // Arrange
            Rectangle shape1 = new(10, 10, 210, 210);
            Rectangle shape2 = new(210, 10, 310, 110);

            // Act
            AdjacencyService service = new AdjacencyService();
            AdjacencyProperty response = service.IsAdjacent(shape1, shape2);

            // Assert
            Assert.AreEqual(AdjacencyType.Partial, response.AdjacencyType);
        }

        [TestMethod]
        public void SegmentPartialAdjacent_Lower1_WithUpper2()
        {
            // Arrange
            Rectangle shape1 = new(10, 10, 210, 210);
            Rectangle shape2 = new(10, 210, 110, 310);

            // Act
            AdjacencyService service = new AdjacencyService();
            AdjacencyProperty response = service.IsAdjacent(shape1, shape2);

            // Assert
            Assert.AreEqual(AdjacencyType.Partial, response.AdjacencyType);
        }

        [TestMethod]
        public void SegmentPartialAdjacent_Lower2_WithUpper1()
        {
            // Arrange
            Rectangle shape2 = new(10, 10, 210, 210);
            Rectangle shape1 = new(10, 210, 110, 310);

            // Act
            AdjacencyService service = new AdjacencyService();
            AdjacencyProperty response = service.IsAdjacent(shape1, shape2);

            // Assert
            Assert.AreEqual(AdjacencyType.Partial, response.AdjacencyType);
        }

        [TestMethod]
        public void SegmentPartialAdjacent_Right2_WithLeft1()
        {
            // Arrange
            Rectangle shape2 = new(10, 10, 210, 210);
            Rectangle shape1 = new(210, 10, 310, 110);

            // Act
            AdjacencyService service = new AdjacencyService();
            AdjacencyProperty response = service.IsAdjacent(shape1, shape2);

            // Assert
            Assert.AreEqual(AdjacencyType.Partial, response.AdjacencyType);
        }

        [TestMethod]
        public void SegmentProperAdjacent_Lower1_WithUpper2()
        {
            // Arrange
            Rectangle shape1 = new(10, 10, 210, 210);
            Rectangle shape2 = new(10, 210, 210, 220);

            // Act
            AdjacencyService service = new AdjacencyService();
            AdjacencyProperty response = service.IsAdjacent(shape1, shape2);

            // Assert
            Assert.AreEqual(AdjacencyType.Proper, response.AdjacencyType);
        }

        [TestMethod]
        public void SegmentAdjacentNone()
        {
            // Arrange
            Rectangle shape1 = new(10, 10, 210, 210);
            Rectangle shape2 = new(210, 210, 210, 220);

            // Act
            AdjacencyService service = new AdjacencyService();
            AdjacencyProperty response = service.IsAdjacent(shape1, shape2);

            // Assert
            Assert.AreEqual(AdjacencyType.None, response.AdjacencyType);
        }
    }
}