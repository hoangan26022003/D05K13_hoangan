package OP.b7_2;

public class Point
{
    private int x;
    private int y;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public int GetX()
    {
        return x;
    }

    public int GetY()
    {
        return y;
    }

    public void SetX(int x)
    {
        this.x = x;
    }

    public void SetY(int y)
    {
        this.y = y;
    }

    public int[] GetXY()
    {
        return new int[] { x, y };
    }

    public void SetXY(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    @Override
    public String toString() {
        return "Point{" +
                "x=" + x +
                ", y=" + y +
                '}';
    }

    public double Distance(Point another)
    {
        int dx = x - another.GetX();
        int dy = y - another.GetY();
        return Math.sqrt(dx * dx + dy * dy);
    }
}