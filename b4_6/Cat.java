package OP.b4_6;

public class Cat extends Mammal {
    public Cat(String name) {
        super(name);
    }

    public void makeSound() {
        System.out.println("meows meows");
    }
    @Override
    public String toString() {
        return "Cat{" + "Mammal{" + "Animal{" +
                "name='" + name + '\'' +
                '}';
    }
}
