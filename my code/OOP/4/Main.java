public class Person{

//Variables
String name;
int age;

//Methods
public void telling(){
System.out.println("Hello, my name is " + name + " and I'm " + age + " years old.");
}

//Main Class
public static void Main(String[] args){

//creating objects
Person p1=new Person();
Person p2=new Person();

//give values for Variables
p1.name="AMKD";
p1.age=23;

p2.name="NSP";
p2.age=22;
 
//now print details using methods
p1.telling();
p2.telling();

 }

}
