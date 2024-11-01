using System;

internal class student
{
    int sid;
    String name;
    int age;

    // member Function
    public void inputdata()
    {
        Console.WriteLine("Enter Student Id:");
        sid = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Student Age");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Student Name");
        name = Console.ReadLine();
    }
    public void Display()
    {
        // Error 1: Replace commas with plus signs for concatenation.
        Console.WriteLine("Student Id is: " + sid);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

class Program
{
    // Error 2: Change "Class" to "class" for the Program class declaration.
    static void Main(string[] args)
    {
        student s1 = new student();
        s1.inputdata();
        s1.Display();
        Console.ReadKey();
    }
}
