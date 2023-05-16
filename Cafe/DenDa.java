package design_pattern.Cafe;

class DenDa implements CaPhe {
    private String loaiCafe;
    private int nhietDoNuoc;

    public DenDa() {
        this.loaiCafe = "Đen đá";
        this.nhietDoNuoc = 30;
    }

    @Override
    public void taoCaPhe() {
        System.out.println("Pha " + loaiCafe);
        System.out.println("Nước nóng: " + nhietDoNuoc + " độ");
    }
}