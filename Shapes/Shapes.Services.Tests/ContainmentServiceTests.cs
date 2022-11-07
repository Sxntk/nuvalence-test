using Shapes.Model;

namespace Shapes.Services.Tests
{
    [TestClass]
    public class ContainmentServiceTests
    {
        [TestMethod]
        public void Rectangle1_ContainsRectangle2()
        {
            // Arrange
            Rectangle shape1 = new(10, 10, 210, 210);
            Rectangle shape2 = new(11, 11, 111, 111);

            // Act
            ContainmentService service = new();
            bool isContained = service.IsContained(shape1, shape2);

            // Assert
            Assert.IsTrue(isContained);
        }

        [TestMethod]
        public void Rectangle1_DoesntContainsRectangle2_StartPointXOutside()
        {
            // Arrange
            Rectangle shape1 = new(10, 10, 210, 210);
            Rectangle shape2 = new(9, 11, 111, 111);

            // Act
            ContainmentService service = new();
            bool isContained = service.IsContained(shape1, shape2);

            // Assert
            Assert.IsFalse(isContained);
        }

        [TestMethod]
        public void Rectangle1_DoesntContainsRectangle2_StartPointYOutside()
        {
            // Arrange
            Rectangle shape1 = new(10, 10, 210, 210);
            Rectangle shape2 = new(11, 9, 111, 111);

            // Act
            ContainmentService service = new();
            bool isContained = service.IsContained(shape1, shape2);

            // Assert
            Assert.IsFalse(isContained);
        }

        [TestMethod]
        public void Rectangle1_DoesntContainsRectangle2_EndpointXTheSame()
        {
            // Arrange
            Rectangle shape1 = new(10, 10, 210, 210);
            Rectangle shape2 = new(11, 11, 210, 111);

            // Act
            ContainmentService service = new();
            bool isContained = service.IsContained(shape1, shape2);

            // Assert
            Assert.IsFalse(isContained);
        }

        [TestMethod]
        public void Rectangle1_DoesntContainsRectangle2_AllPointsTheSame()
        {
            // Arrange
            Rectangle shape1 = new(10, 10, 210, 210);
            Rectangle shape2 = new(10, 10, 210, 210);

            // Act
            ContainmentService service = new();
            bool isContained = service.IsContained(shape1, shape2);

            // Assert
            Assert.IsFalse(isContained);
        }
    }
}