//Creating a class 
class Book {

  //Creating variables with suitable data types
  protected String bookCode;
  protected String bookName;
  protected double bookPrice; //Used double because a price has cents

  //Using default constructor
  public Book(String bookCode, String bookName, double bookPrice) {
    this.bookCode = bookCode;
    this.bookName = bookName;
    this.bookPrice = bookPrice;
  }

  //Using getter methods because attributes are private.
  //We have 3 attributes - so we have to use 3 getters
  public String getBookCode() {
    return bookCode;
  }

  public String getBookName() {
    return bookName;
  }

  public double getBookPrice() {
    return bookPrice;
  }
}
  /*Question says that discounts only available for novels
  But novel is also a type of books
  So Novel is like a child of Book - Then we use inheritance here*/

  //Creating child class
  class Novel extends Book {
    private double discount; //Variable

    /*Again using a constructor but we have to use 
    parameterized constructor according to theory.*/
    public Novel(String bookCode, String bookName, double bookPrice, double discount) {
      super(bookCode, bookName, bookPrice); //This is for getting those attributes from parent class to child class
      this.discount = discount;
    }

    //Now we have to calculate the discount for novels (Using a Method)
    public double calculate() {
      return getBookPrice() * (1 - discount); //This is the calculation
    }
  }

  //Main class to execute all of those methods we created and create objects that we want.
  public class Driver {
    public static void main(String[] args) {
      // Create an instance of the Book class
      Book book = new Book("B001", "Sample Book", 100.0);

      //Question i.Setting data for two novels
      Novel novel1 = new Novel("Nov1", "On Sal Mal Lane", 1500, 0.12);
      Novel novel2 = new Novel("Nov2", "Forget me not", 300, 0.15);

      //Question ii.Calculate price after discount for novel
      double discountedPrice1 = novel1.calculate();
      double discountedPrice2 = novel2.calculate();

      //Question iii.Giving outputs of 2 novels
      System.out.println("Novel 1:");
          System.out.println("Code: " + novel1.getBookCode());
          System.out.println("Title: " + novel1.getBookName());
          System.out.println("Discounted Price: " + discountedPrice1);

          System.out.println("\nNovel 2:");
          System.out.println("Code: " + novel2.getBookCode());
          System.out.println("Title: " + novel2.getBookName());
          System.out.println("Discounted Price: " + discountedPrice2);
    }
  }
