package OP.b4_1;

public class Main {
    public static void main(String[] args) {
        Cylinder cylinder = new Cylinder();
        cylinder.setRadius(1);
        cylinder.setHeight(1);
        System.out.println("Volume: " + cylinder.volume());

        cylinder.area(); // Thuc chat la dien tich day
        // ko hop ly
        // Hinh tru: hien tich xung quanh va dien tich toan phan

    }
}
