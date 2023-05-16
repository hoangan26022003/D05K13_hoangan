package design_pattern.Cafe;

class NauDa implements CaPhe {
    private String loaiCafe;
    private int nhietDoNuoc;

    public NauDa() {
        this.loaiCafe = "Nâu đá";
        this.nhietDoNuoc = 30;
    }

    @Override
    public void taoCaPhe() {
        System.out.println("Pha " + loaiCafe);
        System.out.println("Nước nóng: " + nhietDoNuoc + " độ");
    }
}
