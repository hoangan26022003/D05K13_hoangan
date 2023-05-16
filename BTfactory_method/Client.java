package design_pattern.BTfactory_method;

public class Client {
    public static void main(String[] args) {
        // Tạo thẻ MoneyBack
        CardFactory cardFactory = new CardFactory();
        Card moneyBackCard = cardFactory.createCard("MoneyBack");
        if (moneyBackCard != null) {
            System.out.println("Loại thẻ: " + moneyBackCard.getCardType());
            System.out.println("Hạn mức tín dụng: " + moneyBackCard.getCreditLimit());
            System.out.println("Phí hàng năm: " + moneyBackCard.getAnnualCharge());
        }

        // Tạo thẻ Platinum
        Card platinumCard = cardFactory.createCard("Platinum");
        if (platinumCard != null) {
            System.out.println("Loại thẻ: " + platinumCard.getCardType());
            System.out.println("Hạn mức tín dụng: " + platinumCard.getCreditLimit());
            System.out.println("Phí hàng năm: " + platinumCard.getAnnualCharge());
        }

        // Tạo thẻ Titanium
        Card titaniumCard = cardFactory.createCard("Titanium");
        if (titaniumCard != null) {
            System.out.println("Loại thẻ: " + titaniumCard.getCardType());
            System.out.println("Hạn mức tín dụng: " + titaniumCard.getCreditLimit());
            System.out.println("Phí hàng năm: " + titaniumCard.getAnnualCharge());
        }
    }
}

