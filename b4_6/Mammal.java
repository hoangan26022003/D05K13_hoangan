package OP.b4_6;

public class Mammal extends Animal{
    public String name;
    public Mammal(String name) {
        super(name);
    }
    @Override
    public void makeSound() {
    }

    @Override
    public String toString() {
        return "Mammal{" + "Animal{" +
                "name='" + name + '\'' +
                '}';
    }
}
