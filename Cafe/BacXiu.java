package design_pattern.Cafe;

public class BacXiu implements  CaPhe{
    private String loaiCafe;
    private int nhietDoNuoc;

    public BacXiu() {
        this.loaiCafe = "Bạc xỉu";
        this.nhietDoNuoc = 30;
    }

    @Override
    public void taoCaPhe() {
        System.out.println("Pha " + loaiCafe);
        System.out.println("Nước nóng: " + nhietDoNuoc + " độ");
    }
}
