namespace Programming.Models.Classes;

public static class CollisionManager
{
    public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
    {
        // Calculate the half widths and half heights of the two rectangles
        double halfWidth1 = rectangle1.Width / 2;
        double halfHeight1 = rectangle1.Length / 2;
        double halfWidth2 = rectangle2.Width / 2;
        double halfHeight2 = rectangle2.Length / 2;

        // Calculate the centers of the two rectangles
        double centerX1 = rectangle1.Center.X + halfWidth1;
        double centerY1 = rectangle1.Center.Y + halfHeight1;
        double centerX2 = rectangle2.Center.X + halfWidth2;
        double centerY2 = rectangle2.Center.Y + halfHeight2;

        // Calculate the absolute difference between the X and Y centers
        double diffX = Math.Abs(centerX1 - centerX2);
        double diffY = Math.Abs(centerY1 - centerY2);

        // Check if the rectangles intersect by comparing the difference
        // between their centers to the sum of their half widths and half heights
        return (diffX < halfWidth1 + halfWidth2) && (diffY < halfHeight1 + halfHeight2);

    }

    public static bool IsCollision(Ring ring1, Ring ring2)
    {
        double distance = Point2D.Distance(ring1.Center, ring2.Center);
        double sumOfRadii = ring1.OuterRadius + ring2.OuterRadius;
        if (distance < Math.Abs(ring1.OuterRadius - ring2.OuterRadius))
        {
            // одно кольцо вписано внутрь другого
            return true;
        }
        else
        {
            return distance < sumOfRadii;
        }
    }
}