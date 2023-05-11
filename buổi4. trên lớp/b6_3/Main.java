package OP.b6_3;

public class Main {
    public static void main(String[] args) {
        MovablePoint point = new MovablePoint(0, 0, 2, 3);

        System.out.println("Initial position: " + point);

        point.moveUp();
        System.out.println("After moving up: " + point);

        point.moveLeft();
        System.out.println("After moving left: " + point);

        point.moveDown();
        System.out.println("After moving down: " + point);

        point.moveRight();
        System.out.println("After moving right: " + point);
    }
}
