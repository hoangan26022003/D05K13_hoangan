package OP.b4_6;
public class Dog extends Mammal {
    public Dog(String name) {
        super(name);

    }
    @Override
    public void makeSound() {
        System.out.println("Woof");
    }
    @Override
    public String toString() {
        return "Dog{" + "Mammal{" + "Animal{" +
                "name='" + name + '\'' +
                '}';
    }
}

