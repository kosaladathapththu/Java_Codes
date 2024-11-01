/*A heath system has two classes named Patient and DiabetesPatient. Class Patient has
inheritable attributes boodPresure and heartBeat. The DiabetesPatient class inherited
Patient class. Furthermore, the DiabetesPatient class has a data member named sugarLevel.
Create a Diabetes Patient and assign blood pressure, heartbeat, and the sugar level of the
patient accordingly. You are required to use necessary functions.*/


//20.2F Paper Q-3

class Patient{
	protected double bloodPresure;
	protected double heartBeat;

//use a constructer 
	public Patient(double bloodPresure,double heartBeat){
	this.bloodPresure=bloodPresure;
	this.heartBeat=heartBeat;
    }
}

//Child Class
class DiabetesPatient extends Patient {
	private double suggerLevel;

	//Assign using constructors
    public DiabetesPatient(double bloodPresure,double heartBeat,double suggerLevel){
    	super(bloodPresure,heartBeat);
    	this.suggerLevel=suggerLevel;
    }

    //methods to set suger level
    public void setSuggerLevel(int suggerLevel){
    	this.suggerLevel=suggerLevel;
    }

    //methods to get sugger level
    public double getSuggerLevel(){
    	return suggerLevel;
    }

}

//main class
public class Hospital{
	public static void main(String[] args) {
		

		//Methods for Set  values
		DiabetesPatient Patient1=new DiabetesPatient(80.0,90.2,134.5);
		 

		//display info.
		System.out.println("Patient bloodPresure is:" + Patient1.bloodPresure);
		System.out.println("Patient heartBeat is:" + Patient1.heartBeat);
		System.out.println("Patient suggerLevel is:" + Patient1.getSuggerLevel());

		 



	}
}