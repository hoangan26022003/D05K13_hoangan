package OP.b6_1;

public class Square extends Rectangle {
    protected double side;

    public Square() {
        super();
        this.side = 1.0;
    }

    public Square(double side) {
        super();
        this.side = side;
    }

    public Square(double side, String color, boolean filled) {
        super();
        this.side = side;
    }

    public double getSide() {
        return this.side;
    }

    public void setSide(double side) {
        this.side = side;
    }

    @Override
    public void setWidth(double width) {
        super.setWidth(width);
        this.side = width;
    }

    @Override
    public void setLength(double length) {
        super.setLength(length);
        this.side = length;
    }

    @Override
    public String toString() {
        return "Square [side=" + side + ", color=" + color + ", filled=" + filled + "]";
    }
}
