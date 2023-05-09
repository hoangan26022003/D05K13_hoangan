package OP.b4_6;
public class Dog extends Mammal {
    private String barkType;

    public Dog(String name, String barkType) {
        super(name);
        this.barkType = barkType;
    }

    public String getBarkType() {
        return barkType;
    }

    public void setBarkType(String barkType) {
        this.barkType = barkType;
    }

    public void woof() {
        System.out.println("The dog is barking " + barkType);
    }

    public void wooof() {
        System.out.println("The dog is barking " + barkType + " " + barkType);
    }
}


