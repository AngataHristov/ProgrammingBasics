// Problem 12.	Null Values Arithmetic
// Create a program that assigns null values to an integer and to a double variable.
// Try to print these variables at the console.Try to add some number or the null 
// literal to these variables and print the result.

using System;

class NullValuesArithm
{
    static void Main()
    {
        int intVariable = 0;
        double doubleVariable = 0;

        Console.WriteLine("Integer Variable is:{0} and the Double Variable is:{1}", intVariable, doubleVariable);
        intVariable += 5;
        doubleVariable += 2.5;
        Console.WriteLine("Integer Variable is:{0} and the Double Variable is:{1}", intVariable, doubleVariable);

        Console.WriteLine();
    }
}
