package OP.b4_6;

public class Animal {
    private String name;
    public Animal(String name) {
        this.name = name;
    }

    public String getName() {
        return name;
    }
    public void setName(String name) {
        this.name = name;
    }
    public void eat() {
        System.out.println("The animal is eating");
    }

    public void sleep() {
        System.out.println("The animal is sleeping");
    }

    @Override
    public String toString() {
        return "Animal{" +
                "name='" + name + '\'' +
                '}';
    }
}