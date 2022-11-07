using Shapes.Model;

namespace Shapes.Services
{
    public class AdjacencyService
    {
        public AdjacencyProperty IsAdjacent(Rectangle rectangle1, Rectangle rectangle2)
        {
            // Upper X1 segment with lower X2 segment
            AdjacencyProperty adjacencyProperty = CheckSegmentAdjacent(
                rectangle2.StartPointX,
                rectangle2.EndPointX,
                rectangle2.StartPointY,
                rectangle2.Width,
                rectangle1.StartPointX,
                rectangle1.EndPointX,
                rectangle1.EndPointY,
                rectangle1.Width
                );

            if (adjacencyProperty.AdjacencyType != AdjacencyType.None)
            {
                return adjacencyProperty;
            }

            // Upper X2 segment with lower X1 segment
            adjacencyProperty = CheckSegmentAdjacent(
                rectangle2.StartPointX,
                rectangle2.EndPointX,
                rectangle2.EndPointY,
                rectangle2.Width,
                rectangle1.StartPointX,
                rectangle1.EndPointX,
                rectangle1.StartPointY,
                rectangle1.Width
                );

            if (adjacencyProperty.AdjacencyType != AdjacencyType.None)
            {
                return adjacencyProperty;
            }

            // Left X2 segment with right X1 segment
            adjacencyProperty = CheckSegmentAdjacent(
                rectangle2.StartPointY,
                rectangle2.EndPointY,
                rectangle2.EndPointX,
                rectangle2.Height,
                rectangle1.StartPointY,
                rectangle1.EndPointY,
                rectangle1.StartPointX,
                rectangle1.Height
                );

            if (adjacencyProperty.AdjacencyType != AdjacencyType.None)
            {
                return adjacencyProperty;
            }

            // Left X1 segment with right X2 segment
            adjacencyProperty = CheckSegmentAdjacent(
                rectangle2.StartPointY,
                rectangle2.EndPointY,
                rectangle2.StartPointX,
                rectangle2.Height,
                rectangle1.StartPointY,
                rectangle1.EndPointY,
                rectangle1.EndPointX,
                rectangle1.Height
                );

            return adjacencyProperty;
        }

        private AdjacencyProperty CheckSegmentAdjacent(
            decimal segment2StartX, 
            decimal segment2EndX, 
            decimal segment2StartY, 
            decimal segment2Size, 
            decimal segment1StartX,
            decimal segment1EndX,
            decimal segment1EndY,
            decimal segment1Size)
        {
            if (segment2StartX == segment1StartX &&
                segment2StartY == segment1EndY &&
                segment2Size == segment1Size)
            {
                // Fully adjacent
                return new() { AdjacencyType = AdjacencyType.Proper };
            }

            if (segment2StartX < segment1EndX &&
                segment2EndX > segment1StartX &&
                segment2StartY == segment1EndY)
            {
                // Partial
                return new() { AdjacencyType = AdjacencyType.Partial };
            }

            // No adjacent
            return new() { AdjacencyType = AdjacencyType.None }; ;
        }
    }

    public class AdjacencyProperty
    {
        public AdjacencyType AdjacencyType{ get; set; }

    }

    public enum AdjacencyType
    {
        None,
        Proper,
        Partial,
        Subline
    }
}
