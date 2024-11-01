import java.utill.scanner;
public class perimeter
{
 public static void (string[] args)
{
Scanner perim=new Scanner(System.in);

//create the scanner for Length
System.out.println("Enter Length:");
double Length=scanner.nextDouble();

//scanner for width
System.out.println("Enter width:");
double Width=scanner.nextDouble();

//close
scanner.close();
double peremeter=2*(Length+Width);

//print
System.out.println("The perimeter of rectangle is:"+ peremeter);
 }
}




