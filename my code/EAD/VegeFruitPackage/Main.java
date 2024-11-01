// File: Main.java
import VegeFruitPackage.Vegetable;
import VegeFruitPackage.Fruit;

public class Main {
    public static void main(String[] args) {
        Vegetable carrot = new Vegetable("Carrot", 1.99f, 10.0f);
        Fruit apple = new Fruit(); // Assuming Fruit has similar constructor

        System.out.println("Vegetable: " + carrot.getName() + ", Price: " + carrot.getPrice() + ", Quantity: " + carrot.getQuantity());
    }
}
