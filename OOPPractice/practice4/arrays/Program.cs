/*

    An array stores a fixed-size sequential collection of elements of the same type. An array is used to store a collection of data, but it is often more
    useful to think of an array as a collection of variables of the same type stored at contiguous memory locations.

    Instead of declaring individual variables, such as number0, number1, number2, etc.., number99, i declare one array variable such as numbers and use
    numbers[0], numbers[1], numbers[2], etc, numbers[99] to represent individual variables. A specifict element in an array is accessed by an index.

    All arrays consist of contiguous memory locations. The lowest address corresponds to the first element and the highest address to the last element.

    Declaring Arrays

    datatype[] arrayName;
        where:
        * datatype is used to specify the type of the elements in the array.
        * [] specifies the rank of the array. the rank specifies the size of the array.
        * arrayName specifies the name of the array

    Initializing an array

    declaring an array does not initialize the array in the memory, when the array variable is initialized, you can assign values to the array.
    Array is a reference type, so you need to use new keyword to create an instance of the array. eg:
        double[] balance = new double[10];
    
    Assigning Values to an Array
    You can assign values to individual array elements, by using the index number, like −
    double[] balance = new double[10];
    balance[0] = 4500.0;

    You can assign values to the array at the time of declaration, as shown −
    double[] balance = { 2340.0, 4523.69, 3421.0};

    You can also create and initialize an array, as shown −
    int [] marks = new int[5]  { 99,  98, 92, 97, 95};

    You may also omit the size of the array, as shown −
    int [] marks = new int[]  { 99,  98, 92, 97, 95};

    You can copy an array variable into another target array variable. In such case, both the target and source point to the same memory location −
    int [] marks = new int[]  { 99,  98, 92, 97, 95};
    int[] score = marks;
*/

using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10]; // n is an array of 10 integers

            // initialize elements of array n and output the element's value at the same time

            for(int i = 0; i< 10; i++){
                n[i] = 100 + i;
                // string interpolation
                //Console.WriteLine($"Element[ {i} ]  = { n[i] }");
                // other way of outputing
                // Console.WriteLine("Element[ {0} ] = {1}", i, n[i]);
            }

            // using foreach loop

            foreach(int j in n){

                int i = j-100;
                Console.WriteLine($"Element[ {i} ]  = { j }");
            }
        }

    }
}
