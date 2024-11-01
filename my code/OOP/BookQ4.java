class BookShop{
	protected String code;
	protected String title;
	protected double price;

	//Use Constructer
	public BookShop(String code,String title,double price){
		this.code=code;
		this.title=title;
		this.price=price;
	}

	//include a getter
	public String getCode(){
		return code;
	}	

	public String getTitle(){
		return title;
	}	

	public double getPrice(){
		return price;
	}
        
	
}

//child class
class Novels extends BookShop{
private double discount;

//Assign using constructers
public Novels(String code,String title,double price,double discount){
super(code,title,price); //this is for atribute getting from parent class to child class
this.discount=discount;
}

//Calculation part
public double calculate() {
return getPrice()*(1-discount);
  }
}

//Main class

public class BookQ4{
	public static void main(String[] args) {
		
		//create instance of book
		BookShop b1=new BookShop("BL001","Robinson Croosor",1900);

		//setting data for novels
        Novels nov1=new Novels("Nov001","Madol Duuwa",1000,0.58);
        Novels nov2=new Novels("Nov002","Secret Seven",500,60);

        //calculation for discounted price
        double discountedprice1=nov1.calculate();
        double discountedprice2=nov2.calculate();

//print code,title,discounted price
        //for novel 
        System.out.println("Code:"+ nov1.getCode());
        System.out.println("title"+ nov1.getTitle());
        System.out.println("discountedprice:" + discountedprice1);

        //for novel2
        System.out.println("Code:" + nov2.getCode());
        System.out.println("title;" + nov2.getTitle());
        System.out.println("discountedprice:" + discountedprice2);
	}
}

