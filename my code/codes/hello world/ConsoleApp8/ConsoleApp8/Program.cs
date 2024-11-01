using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
     
    
        class Cylinder {
            int length;
            int radius;
            const double pi = 3.14;

             //default constructors
             public Cylinder()
            {
                length = 5;
                radius = 10;
            }
                //overlord constructor
                public Cylinder(int r, int l) { 
            radius = r;
                length = l;
            }

            //destructor
            ~Cylinder() {
                Console.WriteLine("Cylinder object destroyed");            
            }

            // Method to calculate surface area
            public double SurfaceArea()
            {
                return 2 * pi * radius * (radius + length);
            }

            //Method to calculate volume
            public double volume()
            { 
                return pi * length*radius;
            }
            //methord to display surface and volume
            public void Display()
            {
                Console.WriteLine("Surface Area:" + SurfaceArea());
                Console.WriteLine("Volume:"+volume());
            }

        }
        class Program {
            static void Main(string[] args) {
                // Using default constructor
                Cylinder cyl1 = new Cylinder();
                Console.WriteLine("Cylinder 1:");
                cyl1.Display();

                // Using overloaded constructor
                Cylinder cyl2 = new Cylinder(3, 7);
                Console.WriteLine("\nCylinder 2:");
                cyl2.Display();
            Console.ReadKey();

            }
        
         }
        }
    

