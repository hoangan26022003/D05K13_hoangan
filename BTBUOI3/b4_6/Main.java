package OP.b4_6;
public class Main {
    public static void main(String[] args) {
        Animal animal = new Animal("Generic Animal");
        System.out.println("Name: " + animal.getName());

        Mammal mammal = new Mammal("Generic Mammal");
        System.out.println("Name: " + mammal.getName());

        Dog dog = new Dog("Rufus", "Loud");
        dog.woof();
        dog.wooof();
        System.out.println("Name: " + dog.getName());
    }
}