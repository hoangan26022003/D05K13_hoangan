package design_pattern.BTfactory_method;

public class Titanium implements Card {
    @Override
    public String getCardType() {
        return "Titanium";
    }

    @Override
    public int getCreditLimit() {
        return 2000000;
    }

    @Override
    public int getAnnualCharge() {
        return 1000000;
    }

    @Override
    public void getInfo() {
        System.out.println("Đây là thẻ Titanium");
        System.out.println("Hạn mức tín dụng: " + getCreditLimit());
        System.out.println("Phí hàng năm: " + getAnnualCharge());
    }
}
