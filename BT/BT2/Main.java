package day8.BT.BT2;

public class Main {
    public static void main(String[] args) {
        TinhToanSoThuc tinhToanSoThuc = new TinhToanSoThuc();
        double a = 2.5;
        double b = 1.3;
        System.out.println("Tổng: " + tinhToanSoThuc.cong(a, b));
        System.out.println("Hiệu: " + tinhToanSoThuc.tru(a, b));
        System.out.println("Tích: " + tinhToanSoThuc.nhan(a, b));
        System.out.println("Thương: " + tinhToanSoThuc.chia(a, b));
        System.out.println();
        TinhToanPhanSo tinhToanPhanSo = new TinhToanPhanSo();
        PhanSo phanSo1 = new PhanSo(2, 3);
        PhanSo phanSo2 = new PhanSo(1, 4);
        System.out.println("Tổng: " + tinhToanPhanSo.cong(phanSo1, phanSo2));
        System.out.println("Hiệu: " + tinhToanPhanSo.tru(phanSo1, phanSo2));
        System.out.println("Tích: " + tinhToanPhanSo.nhan(phanSo1, phanSo2));
        System.out.println("Thương: " + tinhToanPhanSo.chia(phanSo1, phanSo2));
    }
}

