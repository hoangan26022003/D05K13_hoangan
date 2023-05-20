package day8.BT.BT1;

public class Drawable {
    public void draw(IHinhHoc hinh) {
        if (hinh instanceof HinhVuong) {
            HinhVuong hinhVuong = (HinhVuong) hinh;
            System.out.println("Vẽ ra HinhVuong[cạnh = " + hinhVuong.getCanh() + "]");
        } else if (hinh instanceof HinhTron) {
            HinhTron hinhTron = (HinhTron) hinh;
            System.out.println("Vẽ ra HinhTron[bán kính = " + hinhTron.getBankinh() + "]");
        } else {
            System.out.println("Không thể vẽ hình này");
        }
    }
}
