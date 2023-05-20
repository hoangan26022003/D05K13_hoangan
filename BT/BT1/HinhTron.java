package day8.BT.BT1;

public class HinhTron implements IHinhHoc{
    private double bankinh;

    public HinhTron(double bankinh) {
        this.bankinh = bankinh;
    }

    @Override
    public double tinhChuVi() {
        return 2 * Math.PI * bankinh;
    }

    @Override
    public double tinhDienTich() {
        return Math.PI * bankinh * bankinh;
    }

    public double getBankinh() {
        return bankinh;
    }

    public void setBankinh(double bankinh) {
        this.bankinh = bankinh;
    }
}
