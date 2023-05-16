package design_pattern.BTfactory_method;

public class CardFactory {
    public Card createCard(String type) {
        if (type.equals("MoneyBack")) {
            return new MoneyBack();
        } else if (type.equals("Platinum")) {
            return new Platinum();
        } else if (type.equals("Titanium")) {
            return new Titanium();
        }
        return null;
    }
}

