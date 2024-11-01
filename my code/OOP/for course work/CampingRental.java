/*ABC Company rents camping tents to customers. Design an object-oriented program to manage the camping tent rentals. Consider the following tasks:

i. Define classes for Customer and CampingTent with appropriate attributes.
ii. Implement methods setCustomerData() and setCampTentData() to set data for customers and camping tents respectively.
iii. Implement a method funcOrder() to check the availability of a camping tent and confirm the order.*/



class Customer {
	private String custID;
	private String custName;
	private String mobileNo;
	private String tentId;

	//Create Constructer
	public Customer(String custID,String custName,String mobileNo,String tentId){
		this.custID=custID;
		this.custName=custName;
		this.mobileNo=mobileNo;
		this.tentId=tentId;
	}

	//Set getters

	public String getcustId(){
		return custID;
	}

	public String custName(){
		return custName;
	}

	public String mobileNo(){
		return mobileNo;
	}

	public String tentId(){
		return tentId;
	}

}

class CampingTent{
	
}