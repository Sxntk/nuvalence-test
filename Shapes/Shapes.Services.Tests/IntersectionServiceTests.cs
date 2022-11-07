using Shapes.Model;

namespace Shapes.Services.Tests
{
    [TestClass]
    public class IntersectionServiceTests
    {
        [TestMethod]
        public void IsIntersected()
        {
            // Arrange
            Rectangle shape1 = new(10, 10, 210, 210);
            Rectangle shape2 = new(210, 10, 310, 110);

            // Act
            IntersectionService service = new IntersectionService();
            service.IsIntersected(shape1, shape2);

            // Assert
        }
    }
}