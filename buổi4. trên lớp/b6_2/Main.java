package OP.b6_2;

public class Main {
    public static void main(String[] args) {
        Circle circle = new Circle(2.0);
        Rectangle rectangle = new Rectangle(4.0, 6.0);

        double circleArea = circle.getArea();
        double circlePerimeter = circle.getPerimeter();
        double rectangleArea = rectangle.getArea();
        double rectanglePerimeter = rectangle.getPerimeter();

        System.out.println("Circle Area: " + circleArea);
        System.out.println("Circle Perimeter: " + circlePerimeter);
        System.out.println("Rectangle Area: " + rectangleArea);
        System.out.println("Rectangle Perimeter: " + rectanglePerimeter);
    }
}
