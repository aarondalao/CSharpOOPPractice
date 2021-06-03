/*
    A method is a group of statement that together perform a task
    Every C# program has at least one class with a method named Main()

    to use a method, i need to 

        * Define the method
        * Call the method

    Defining the method basically declares the elements of its structure. the syntax for defining a method in C# is:

    <Access Specifier> <Return Type> <Method Name>(Parameter List) {
        Method Body
    }

    various elements of a method are as follows:

    Access specifier - this determines the visibiility of a variable or a method from another class.
    
    Return type - A method may return a value. The return type is the data type of the value the method returns. IF the method is not returning any values, 
                then the return type is void.
    
    Method name - Method name ius a unique identifier and it is case sensitive. it cannot be the same as aany othe identifier declared in the class

    Parameter list - Enclosed between parentheses, the parameters are used to pass and receive data from a method. The parameter list refers to the type, 
    order, and number of the parameters of a method, parameters are optional, that is, a method may container no parameters.

    Method body - contains the set of instructions need to complete the required activity.


*/

using System;

namespace practice2
{
    class Program
    {
        public int FindMax(int num1, int num2){
            // local variable declaration
            // also tried the shorthand for if else statements using a ternary operator
            // syntax:
            // variable = (condition) ? expression1 : expression2
            // note:
            // I CAN ONLY USE THIS FOR SIMPLE IF ELSE STATEMENTS!
            int result = (num1 > num2) ? result = num1 : result = num2;
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int a = 200, b = 888;
            // created an object for my class Program, which is the main class
            Program p = new Program();

            // created another object for the class Test, which is another class aside from the main class called Program
            // notice that i can still access the test class as the FindMax2 method has a public access specifier.
            Test t = new Test();
            
            // created an object named n from the class numberManipulators for me to access the recursive function factorial
            numberManipulators n = new numberManipulators();



            // used the object to call the method FindMax() to find the max. then output it to the console.writeline
            Console.WriteLine($"Max value is {p.FindMax(a,b)} ");
            Console.WriteLine($"Max value is {t.FindMax2(a,b)} ");


            // calling the factorial method {0}, n.factorial(6)

            Console.WriteLine($"factorial of 6 is: {n.factorial(6)}");
            Console.WriteLine($"factorial of 7 is: {n.factorial(7)}");
            Console.WriteLine($"factorial of 8 is: {n.factorial(8)}");
            Console.WriteLine($"factorial of 9 is: {n.factorial(9)}");

        }
    }

    class Test{
        public int FindMax2(int num1, int num2){
            // local variable declaration
            // also tried the shorthand for if else statements using a ternary operator
            // syntax:
            // variable = (condition) ? expression1 : expression2
            // note:
            // I CAN ONLY USE THIS FOR SIMPLE IF ELSE STATEMENTS!
            int result = (num1 > num2) ? result = num1 : result = num2;
            return result;
        }
    }
    // below is a recursive method inside the class called numberManipulators
    //
    class numberManipulators{
        public int factorial(int num){
            int result;
            if(num == 1){
                return 1;
            }
            else{

                // this called numerous times until the value of num is equal to 1
                
                result = factorial(num - 1 ) * num;
                return result;
            }
        }
    }
}
