package OP.b7_2;

import java.util.ArrayList;
import java.util.List;

public class PolyLine
{
    private List<Point> points; // List of Point instances

    // Constructors
    public PolyLine()
    {
        points = new ArrayList<Point>(); // implement with List<Point>
    }

    public PolyLine(List<Point> points)
    {
        this.points = points;
    }

    // Append a point (x, y) to the end of this polyline
    public void appendPoint(int x, int y)
    {
        Point newPoint = new Point(x, y);
        points.add(newPoint);
    }

    // Append a point instance to the end of this polyline
    public void appendPoint(Point point)
    {
        points.add(point);
    }

    // Return {(x1,y1)(x2,y2)(x3,y3)....}

    @Override
    public String toString() {
        StringBuilder sb = new StringBuilder("{");
        for (Point aPoint : points)
        {
            sb.append(aPoint.toString());
        }
        sb.append("}");
        return sb.toString();
    }


    // Return the total length of this polyline
    public double getLength()
    {
        double totalLength = 0.0;
        Point previousPoint = null;
        for (Point currentPoint : points)
        {
            if (previousPoint != null)
            {
                totalLength += previousPoint.Distance(currentPoint);
            }
            previousPoint = currentPoint;
        }
        return totalLength;
    }
}
