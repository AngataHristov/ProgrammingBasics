// Problem 10.	Employee Data
// A marketing company wants to keep record of its employees.Each record would have the following characteristics:
// •	First name
// •	Last name
// •	Age (0...100)
// •	Gender(m or f)
// •	Personal ID number(e.g. 8306112507)
// •	Unique employee number(27560000…27569999)
// Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
// Use descriptive names.Print the data at the console.


using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Angel";
        string middleName = "Georgiev";
        string lastName = "Hristov";
        byte age = 25;
        char gender = 'm';
        long ID = 8306112507;
        long uniqueNumber = 2756027569999;

        Console.WriteLine("{0} {1} {2}" + "\n" + "Age= {3}" + "\n" + "Gender: {4}" +
        "\n" + "ID: {5}" + "\n" + "Unique Employee Number: {6}", firstName, middleName,
        lastName, age, gender, ID, uniqueNumber);
        Console.WriteLine();
    }
}
