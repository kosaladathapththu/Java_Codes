class Guest{
	protected String guestID;
	protected int billAmount;


//use a Constructor for set datas
	public Guest(String guestID,int billAmount){
	this.guestID=guestID;
	this.billAmount=billAmount;
   }
 
 //include a getter 
   public String getGuestID(){
    return guestID;
   }

   public int getBillAmount(){
   	return billAmount;
   }
}

class ForiegnGuest extends Guest{
  private double taxRate;

  //Use a constructor for set a data for child class
  public ForiegnGuest(String guestID,int billAmount,double taxRate){
  	super(guestID,billAmount);
  	this.taxRate=taxRate;
  }


//Calculate the bill amount
  public double calculation(){
  	return getBillAmount()*(1+taxRate);
  }
}


class Hotel{
	public static void main(String[] args) {

//set data for foriegn guest	
    ForiegnGuest guest1=new ForiegnGuest("G001" , "40000" , 0.15);

//display out for details 
    System.out.println("Guest Id:" + guest1.getGuestID());
    System.out.println("Bill Amount is:" + guest1.getBillAmount());
    System.out.println("Your Final Bill is:" + guest1.calculation());


	}
}