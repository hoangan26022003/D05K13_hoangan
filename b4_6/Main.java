package OP.b4_6;

public class Main {
    public static void main(String[] args) {
        Dog d1 = new Dog("cho");
        System.out.println();
        Animal[] animals = new Animal[4];
        animals[0] = new Cat("cho");
        animals[1] = new Dog("meo");
        animals[2] = new Dog("Pitbull");
        animals[3] = new Cat("Pitbull");
        for (Animal animal : animals) {
            animal.makeSound();
        }
    }
}
