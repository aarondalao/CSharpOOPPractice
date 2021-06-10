using System;

namespace arrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // exericise 1
            // exercise1 ex1 = new exercise1();
            // ex1.Store();
            // ex1.Display();
            
            // exercise2
            // exercise2 ex2 = new exercise2();
            // Console.WriteLine("Input the number of elements to store in the array: ");
            // int x = ex2.setMaxNum(Convert.ToInt32(Console.ReadLine()));
            // Console.WriteLine($"Input {x} number of elements in the array:");
            // ex2.Store(x);
            // ex2.reversion();

            // exercise 3
            // Exercise3 ex3 = new Exercise3();
            // ex3.getArraySizeAndElements();
            // ex3.sumOfElements();

            // exercise4
            Exercise4 ex4 = new Exercise4();
            ex4.enterArrayMax();
            ex4.acceptArrayElements();
            ex4.copyArrays();
        }
               
    }


    // write a program in C# to store element in an array and print it.
    // hard mode: implement it using classes as well.
    class exercise1{
        private int[] num = new int[10];
        public void Store(){
            for(int i = 0;i<10;i++){
                Console.WriteLine("Element [{0}] : ", i);
                num[i] = Convert.ToInt32(Console.ReadLine()); 
            }
        }
        public void Display(){
            Console.Write("Elements inside the array are: ");
            for(int i = 0; i <10; i++){
                Console.Write(num[i] + " ");
            }
            
        }
    }

    // write a program to read N numbers in an array and display in inreverse orrder
    class exercise2{
        private int[] ReverseNum;
        public int setMaxNum(int number){
            ReverseNum = new int[number];
            return number;
        }

        public void Store(int num){
            for(int i = 0;i<num;i++){
                Console.WriteLine("Element [{0}] : ", i);
                ReverseNum[i] = Convert.ToInt32(Console.ReadLine()); 
            }
        }
        
        public void reversion(){
            Console.WriteLine("The values stored in to the array are: ");
            for(int j = 0; j < ReverseNum.Length; j++){
                Console.Write(ReverseNum[j] + " ");
            }
            Console.WriteLine(" ");
            Array.Reverse(ReverseNum);
            Console.WriteLine("The values stoired in to the array in REVERSE are: ");

            for(int j = 0; j < ReverseNum.Length; j++){
                Console.Write(ReverseNum[j] + " ");
            }
        }
    }
    // write a program to find the sum of all elements of the array
    class Exercise3{
        private int[] num;
        private int sum= 0;

        public void getArraySizeAndElements(){
            // set the array size and place inputs inside the array. x is only a placeholder
            Console.WriteLine("Input the number of elements to be stored in the array: ");
            int x = Convert.ToInt32(Console.ReadLine());
            num = new int[x];

            // place elements inside of the array with x length
            Console.WriteLine($"Input {x} elements in the array: ");
            for(int i = 0; i < num.Length; i++){
                Console.WriteLine("Element [{0}] : ", i);
                num[i] = Convert.ToInt32(Console.ReadLine()); 
            }

            // just an extra bit to see if i actually managed to store my arrays. just in case.
            Console.WriteLine("my elements inside array num are:");
            for(int j = 0; j < num.Length; j++){
                Console.Write(num[j] + " ");
            }
            
        }

        public void sumOfElements(){
            // i was leaning towards the foreach approach but it was producing an indexOutOfBounds Error
            // i might need to research on that again.
            for(int n=0; n < num.Length;n++ ){
                sum += num[n];
            }
            Console.WriteLine($"the sum of all elements stored in the array is: {sum}");
        }
    }
    /*
        Write a program to copy the elements one array into another array

    */
    class Exercise4{
        private int[] myArray1, myArray2;

        // enter the maximum index / length of my 2 arrays.
        public void enterArrayMax(){
            Console.WriteLine("Input the number of elements to be stored in the array: ");
            int x = Convert.ToInt32(Console.ReadLine());
            myArray1 = new int[x];
            myArray2 = new int[x];
        }

        // accept and store values to myArray1
        public void acceptArrayElements(){
            Console.WriteLine($"Input {myArray1.Length} elements in the array: ");
            for(int i = 0; i < myArray1.Length; i++){
                Console.WriteLine("Element [{0}] : ", i);
                myArray1[i] = Convert.ToInt32(Console.ReadLine()); 
            }

            // just an extra bit to see if i actually managed to store my arrays. just in case.
            Console.WriteLine("my elements inside myArray1 are:");
            for(int j = 0; j < myArray1.Length; j++){
                Console.Write(myArray1[j] + " ");
            }
        }
        // copy elements of myArray1 into myArray2
        public void copyArrays(){

            // this problem has two solutions
            // first, the traditional for loop to traverse the myArray1 and copy it to the myArray2

            for(int i = 0 ; i < myArray1.Length; i++){
                myArray2[i] = myArray1[i];
            }
            // printing elements inside array2
            
            Console.WriteLine($"the arrays inside myArray2 using the traditional for loop statement:");
            for(int c = 0; c < myArray2.Length;c++){
                Console.Write(myArray2[c] + " ");
            }
            // second, using the Array.CopyTo or Copy Methods.
            // syntax , Array.Copy(source, target, length); 
            
            /*
                in the lenght variable, we can use the following to get the length
                *   for example , an external variable int x from the enterArrayMax Method
                * or , using the .Length Property of the myArray1/2
            */
            Array.Copy(myArray1, myArray2, myArray2.Length);
            Console.WriteLine($"the arrays inside myArray2 using Array.Copy Method:");
            for(int c = 0; c < myArray2.Length;c++){
                Console.Write(myArray2[c] + " ");
            }

        }
    }
}
