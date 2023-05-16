package design_pattern.Cafe;

public class Latte implements CaPhe{
    private String loaiCafe;
    private int nhietDoNuoc;

    public Latte() {
        this.loaiCafe = "Latte";
        this.nhietDoNuoc = 30;
    }

    @Override
    public void taoCaPhe() {
        System.out.println("Pha " + loaiCafe);
        System.out.println("Nước nóng: " + nhietDoNuoc + " độ");
    }
}
