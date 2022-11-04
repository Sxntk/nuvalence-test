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
            Rectangle shape1 = new(10, 10, 20, 20);
            Rectangle shape2 = new(15, 15, 25, 25);
            IntersectionService service = new IntersectionService();
            service.IsIntersected(null, null);
        }
    }
}