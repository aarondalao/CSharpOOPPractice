/*
    Nullable types

    C# Provides a special data types, the nullable types, to which you can assign normal range of valuyes as well as null values.

    for example you can store any value from -2,147,483,648 to 2,147,483,647 or null in a Nullable<Int32> variable. Simillarly,you can assign true, false, or null in a nullable<bool>
    variable.

    Syntax:
        < data_types >? < variable_name > = null;
*/

using System;

namespace hamburger
{
    class Program
    {
        static void Main(string[] args)
        {
            // examples of nullable types

            int?  num1 = null;
            int? num2 = 456;
            

            double? num3 = new double?();
            double? num4 = 3.14157;

            bool? boolval = new bool?();

            // display the values 
            Console.WriteLine($"Nullables at show: {num1}, {num2}, {num3}, {num4}");
            Console.WriteLine($"Nullable bool value: {boolval} ");



            // The null coalesciung operator is used with the nullable vaules types and reference types. it is used for converting an operand to the type of
            // another nullable (or not) value type operand, where an implicit conversion is possible.

            // if the valuye of the first operand is null, then the operator returns the value of the second operand,
            // otherwise it returns teh value of the first operand.

            // example of Null Coalescing Operator(??)

            double? n1 = null;
            double? n2 = 3.14157;
            double n3;

            n3 = n1 ?? 5.34;
            Console.WriteLine("Value of n3: {0}", n3);

            n3 = n2 ?? 5.34;
            Console.WriteLine("Value of n3: {0}", n3);
        }
    }
}
