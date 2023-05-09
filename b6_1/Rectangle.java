package OP.b6_1;

public class Rectangle extends Shape {
    protected double width = 1.0 ;
    protected double length = 1.0;
    public Rectangle(double v, double v1, String red, int i) {}

    public Rectangle(String color, boolean filled) {
    }


    public double getWidth() {
        return width;
    }

    public void setWidth(double width) {
        this.width = width;
    }

    public double getLength() {
        return length;
    }

    public void setLength(double length) {
        this.length = length;
    }

    @Override
    public double getArea() {
        return width * length;
    }

    @Override
    public double getPerimeter() {
        return 2 * (width + length);
    }

    @Override
    public String toString() {
        return "Rectangle color is " + color +"And filled is " + filled + " and width is " + width + " and length is " + length;
    }

    public double getSide() {
        return 0;
    }
}
