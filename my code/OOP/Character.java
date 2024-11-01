/*Design a role-playing game (RPG) where players 
control different characters with unique abilities. 
Define a base class Character with methods for attacking, defending, and moving. Create subclasses
 representing different character types (e.g., warrior, mage, archer) that inherit from Character. 
 Each subclass should override the methods to implement specific abilities for that character type. 
 Show polymorphism by allowing players to control different character types interchangeably.*/


class  Character{
	public void attacking(){
		System.out.println("he is good in attacking");
	}

	public void defending(){
		System.out.println("he doing defending well");
	}

	public void moving(){
		System.out.println("he moving well");
	}

}

class Warrior extends Character{
	public void attacking(){
		System.out.println("he is not good in attacking");
	}
	public void defending(){
		System.out.println("he can't defending");
	}

	public void moving(){
		System.out.println("he can't move");
	}
}

class Mage extends Character{
	public void defending(){
		System.out.println("he can't defending");
	}
	public void attacking(){
		System.out.println("he is not good in attacking");
	}
	public void moving(){
		System.out.println("he can't move");
	}
}

class Archer extends Character{
    public void moving(){
		System.out.println("he can't move");
	}
	public void attacking(){
		System.out.println("he is not good in attacking");
	}

	public void defending(){
		System.out.println("he can't defending");
	}
}
//main class
public class RPG{
	 public static void main(String[] args) {
	
		//create objects
		Character obj1=new Character();
		Warrior obj2 = new Warrior();
		Mage obj3=new Mage();
		Archer obj4=new Archer();
		 
		//calling objects
		obj1.attacking();
		obj1.defending();
		obj1.moving();

		obj2.attacking();
		obj2.defending();
		obj2.moving();

		obj3.defending();
		obj3.attacking();
		obj3.moving();

		obj4.moving();
		obj4.attacking();
		obj4.defending();

	}
}