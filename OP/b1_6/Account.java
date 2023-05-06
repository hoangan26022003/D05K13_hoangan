package OP.b1_6;

public class Account {
    private String id;
    private String name;
    private int balance = 0;
    public Account(String id, String name) {
        this.id = id;
        this.name = name;
    }
    public Account(String id, String name, int balance) {
        this.id = id;
        this.name = name;
        this.balance = balance;
    }
    public String getID() {
        return id;
    }

    public String getName() {
        return name;
    }

    public int getBalance() {
        return balance;
    }
    public int credit(int amount) {
        balance += amount;
        return balance;
    }
    public void debit(double amount) {
        if (balance >= amount) {
            balance -= amount;
        } else {
            System.out.println("Amount exceeded balance.");
        }
    }
    public int transferTo( Account another, int amount) {
        if (amount <= balance){
            this.debit(amount);
            another.credit(amount);
        } else {
        System.out.println("Amount exceeded balance.");
                }
        return balance;
    }

    @Override
    public String toString() {
        return "Account{" +
                "id='" + id + '\'' +
                ", name='" + name + '\'' +
                ", balance=" + balance +
                '}';
    }
}
