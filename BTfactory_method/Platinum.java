package design_pattern.BTfactory_method;

public class Platinum implements Card {
    @Override
    public String getCardType() {
        return "Platinum";
    }

    @Override
    public int getCreditLimit() {
        return 1000000;
    }

    @Override
    public int getAnnualCharge() {
        return 500000;
    }

    @Override
    public void getInfo() {
        System.out.println("Đây là thẻ Platinum");
        System.out.println("Hạn mức tín dụng: " + getCreditLimit());
        System.out.println("Phí hàng năm: " + getAnnualCharge());
    }
}
