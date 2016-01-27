// Problem 6.	Strings and Objects
// Declare two string variables and assign them with “Hello” and “World”.
// Declare an object variable and assign it with the concatenation of the
// first two variables(mind adding an interval between). Declare a third 
// string variable and initialize it with the value of the object variable.

using System;

class StringsAndObjects
{
    static void Main()
    {
        string stringOne = "Hello";
        string stringTwo = "World !";
        object stringOneTwo = stringOne + " " + stringTwo;
        string newString = (string)stringOneTwo;
        Console.WriteLine(newString);
    }
}
