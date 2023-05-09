package OP.b5_2;


public class Cylinder {
    private Circle base;
    private double height;

    public Cylinder(double height){
        base = new Circle();
        this.height = height;
    }
    public Cylinder(double radius, double height){
        base = new Circle(radius);
        this.height = height;
    }
    public Cylinder(double radius, double height, String color){
        base = new Circle(radius, color);
        this.height = height;
    }

    public Circle getBase() {
        return base;
    }

    public void setBase(Circle base) {
        this.base = base;
    }

    public double getHeight() {
        return height;
    }

    public void setHeight(double height) {
        if(height <= 0){
            throw new RuntimeException("Chieu cao phai duong");
        }
        this.height = height;
    }
    public double getVolume(){
        return base.area() * height;
    }
}
