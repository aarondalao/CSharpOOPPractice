/*
    this is a practice for data encapsulation, an OOP Concept
    ecapsulation is defind as the process of enclosing one or more items within
    a physical or logical package.

    in oop methodology, it means that encapsulation prevents access to 
    implementation details.

    Abstraction and encapsulation are related features in object oriented programming. ABSTRACTION allows making RELEVANT INFORMATION VISIBLE 
    and ENCAPSULATION enables a programmer to IMPLEMENT THE DESIRED LEVEL OF ABSTRACTION.

    Encapsulation is implement by using access specifiers. An access specifiers defines the scope and visibility of a  class member.
    C# supports the folloing access specifiers-
        *   Public  
        *   Private
        *   Protected
        *   Internal
        *   Protected internal


    

    Cited at https://www.tutorialspoint.com/csharp/csharp_encapsulation.htm
*/
using System;

namespace practice1
{
    // start of executing the program
    class Program
    {
        static void Main(string[] args)
        {   
            // used for making an example for public acess specifier
            // Rectangle r = new Rectangle();
            // r.length = 4.5;
            // r.width = 3.5;
            // r.Display();
            // Console.ReadLine();

            // used for making an example for private acess specifier

            // Rectangle1 r = new Rectangle1();    
            // r.AcceptDetails();
            // r.Display();
            // Console.ReadLine();

            Rectangle2 r = new Rectangle2();    
            r.length = 10;
            r.width = 10;
            r.Display();
            Console.ReadLine();
        }
    }

    class Rectangle{
        // member variables using public acces specifier
        /* 
            public AccessViolationException specifier allows a class to expose its member variables and member functions to other functions and objects
            any public member can be accessed from outside the class
        */
        public double length;
        public double width;    
        
        public double GetArea(){
            return length * width;
        }
        
        public void Display(){

            Console.WriteLine($"Length: {length}");
            Console.WriteLine($"Width: {width}");
            Console.WriteLine("Get Area: {0}", GetArea());
        }
    }// end of class rectangle


    // private access specifiers
    /*
        Privater accesss specifier allows a class to hide its member variables and member function from other functions and objets. Only functions of the
        smae class can access its private member. Even an instance of a class cannot access its private members.
    */
    class Rectangle1 {

        // these member variables cannot be accessed by function Main() but the member functions AcceptDetails() and Display can.
        
        private double length;
        private double width;

        /*  

        */
        public void AcceptDetails(){
            Console.WriteLine("Enter length:");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter width:");
            width = Convert.ToDouble(Console.ReadLine());
        }

        public double GetArea(){

            return length * width;
        }
        public void Display(){
            Console.WriteLine($"Length: {length}");
            Console.WriteLine($"Width: {width}");
            Console.WriteLine("Get Area: {0}", GetArea());
        }
    }
    // end of private access specifiers


    // start of protected  and Protected Internal access specifiers

    /*
        Protected access specifier allows a child class to access the member variables and member functions of its base class. 
        This way it helps in implementing inheritance. We will discuss this in more details in the inheritance chapter.

        On the other hand, the protected internal access specifier allows a class to hide its member variables and member functions from other class objects and functions, 
        except a child class within the same application. 
        This is also used while implementing inheritance.
    */

    // end of protected  and Protected Internal access specifiers



    // start of internal access specifiers

    /*
        internal access specifier allos a class to expose its member variavbles and member functions and object in the current assembly.
        In other words, any member with internal access specifier can be accessed from any class or methdo defind with the application in which the 
        member is defined
    */

    class Rectangle2{
        // member variables below here! 
        internal double length;
        internal double width;
        public double GetArea(){

            return length * width;
        }
        public void Display(){
            Console.WriteLine($"Length: {length}");
            Console.WriteLine($"Width: {width}");
            Console.WriteLine("Get Area: {0}", GetArea());
        }
    }

    // end of proected access specifiers


}
