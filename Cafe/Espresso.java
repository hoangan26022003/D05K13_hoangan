package design_pattern.Cafe;

class Espresso implements CaPhe {
    private String loaiCafe;
    private int apSuat;
    private String nuoc;

    public Espresso() {
        this.loaiCafe = "Espresso";
        this.apSuat = 5;
        this.nuoc = "Nước nóng";
    }

    @Override
    public void taoCaPhe() {
        System.out.println("Pha " + loaiCafe);
        System.out.println("Áp suất: " + apSuat + " Pa");
        System.out.println("Nước: " + nuoc);
        // Các bước pha cà phê Espresso
    }
}

