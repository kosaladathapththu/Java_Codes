// File: VegeFruitPackage/Vegetable.java
package VegeFruitPackage;

public class Vegetable {
    private String name;
    private float price;
    private float quantity;

    // Constructor
    public Vegetable(String name, float price, float quantity) {
        this.name = name;
        this.price = price;
        this.quantity = quantity;
    }

    // Getters and Setters
    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public float getPrice() {
        return price;
    }

    public void setPrice(float price) {
        this.price = price;
    }

    public float getQuantity() {
        return quantity;
    }

    public void setQuantity(float quantity) {
        this.quantity = quantity;
    }
}
