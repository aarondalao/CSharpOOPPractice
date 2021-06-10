/* 

    multi-dimensional arrays
        - are also called rectangular arrays.
    
    you can declare a 2-dimensional array of int variables as 

    int[,] names;

    or a 3 dimensional array of int variables as 

    int[,,] m;

    The simplest form of the multidimensional array is the 2-dimensional array. A 2-dimensional array is a list of 
    one-dimensional array. It can be thought of as a table, which has a x number of rows and y number of columns.

                                    Column 0    Column 1      Column 2        Column  3         
                                ___________________________________________________________   
                        row 0  |  a[0][0]    |   a[0][1}   |    a[0][2]     |   a[0][3]   |      
                            ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯
                        row 1  |  a[1][0]    |    a[1][1]   |    a[1][2]     |   A[1][3]  |
                            ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯
                        row 2  |  a[2][0]    |    a[2][1]   |    a[2][2]     |   A[2][3]  |
                            ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯ 
                        row 3  |  a[3][0]    |    a[3][1]   |    a[3][2]     |   A[3][3]  | 
                            ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯  

    Thus, every element in the array a is identified by an element name of the form a[i,j], where a is the name of the 
    array, and i and j area the subscripts that uniquely identify each element in array a.

*/ 

using System;

namespace AdvanceArrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            // initializeing 2-D arrays
            // multidimensional arrays may be initialzed by specifiying bracketed values for each row. The following array 
            // with 3 rows and each row has 4 columns.

            int[,] a = new int [3,4]{
                {0,1,2,3},
                {4,5,6,7},
                {8,9,10,10}
            };

            // accessing 2-D array elements
            // an element in 2-dimensional array is accessed by using subscripts. That is, row index and column index of 
            // the array, For example:

            int val = a [2,3];

            // the above statement takes 4th element form the 3rd row of the array, You can verify it in the above diagram


            // complete example

            // an array of 5 rows and 2 columns
            int[,] b = new int[5,2]{ {0,0},{11,22},{33,44},{55,66},{77,88} };

            // output each array element,s value

            for(int i=0; i<5;i++){
                for(int j = 0; j <2; j++){
                    Console.WriteLine("b[{0},{1}] = {2}", i,j,b[i,j]);
                }
            }
            Console.ReadKey();


        }
    }
}
