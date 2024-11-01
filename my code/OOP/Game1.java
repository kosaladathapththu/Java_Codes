/*Assume that you are developing a game application of which you have enemies. Each
enemy has data members named x and y which can store x and y coordinates of the enemy.
Declare enemy class with given data members. First enemy object is created at coordinates
(x=0, y=0). Then all the new enemy objects should be created coping coordinates of last
enemy object. Define suitable constructors. Create two enemy objects and initialize x and
y accordingly. Use destructor in the class to release memory.*/

public class enemy{
	int x;
	int y;

	//adding constructer
	public enemy(){
	this.x=0;
	this.y=0;
   }
}