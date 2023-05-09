package OP.b6_1;

public class Square extends Rectangle {
    protected double side = 1.0 ;
    public Square() {
        super(1.0, 2.0, "red", 25);
    }

    public Square(double side) {
        super(1.0, 2.0, "red", 25);
        this.side = side;
    }

    public Square(double side, String color, boolean filled) {
        super(color, filled);
        this.side = side;
    }

    public double getSide() {
        return side;
    }

    public void setSide(double side) {
        setWidth(side);
        setHeight(side);
    }

    private void setHeight(double side) {
    }


    @Override
    public String toString() {
        return "Square color is " + color + " and side is " + getWidth();
    }
}