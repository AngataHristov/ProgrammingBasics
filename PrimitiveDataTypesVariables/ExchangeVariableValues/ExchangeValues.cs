// Problem 9.	Exchange Variable Values
// Declare two integer variables a and b and assign them with 5 and 10 and after
// that exchange their values by using some programming logic.Print the variable
// values before and after the exchange.

using System;

class ExchangeValues
{
    static void Main()
    {
        int variableOne = 5;
        int variableTwo = 10;
        int variableThree = new int();
        Console.WriteLine("Values befor exchange are:" + "\n" + "a={0}" + "\n" + "b={1}", variableOne, variableTwo);
        variableThree = variableOne;
        variableOne = variableTwo;
        variableTwo = variableThree;
        Console.WriteLine("Values after exchange are:" + "\n" + "a={0}" + "\n" + "b={1}", variableOne, variableTwo);
    }
}
