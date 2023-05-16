package design_pattern.BTfactory_method;

public class MoneyBack implements Card {
    @Override
    public String getCardType() {
        return "MoneyBack";
    }

    @Override
    public int getCreditLimit() {
        return 500000;
    }

    @Override
    public int getAnnualCharge() {
        return 0;
    }

    @Override
    public void getInfo() {
        System.out.println("Đây là thẻ MoneyBack");
        System.out.println("Hạn mức tín dụng: " + getCreditLimit());
        System.out.println("Phí hàng năm: " + getAnnualCharge());
    }
}
