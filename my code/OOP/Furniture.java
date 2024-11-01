class furniture{
	string code;
	string group;
	double price;

	//adding constructor
	public (string code,string group,double price){
		this.code=code;
		this.group=group;
		this.price=price;
    }
    //update the selling price of furniture after discount
    public void Discount(double DiscountRate){
    	double discountAmount=price*(DiscountRate/100);
    	price=discountAmount;
    }
//

}