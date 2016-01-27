// Problem 2.	Print Company Information
// A company has name, address, phone number, fax number, web site and manager.The manager has first name,
// last name, age and a phone number.Write a program that reads the information about a company and its
// manager and prints it back on the console.

using System;

class PrintCompanyInfo
{
    static void Main()
    {
        Console.WriteLine("Company name: ");
        string companyName = Console.ReadLine();

        Console.WriteLine("Company address: ");
        string companyAddress = Console.ReadLine();

        Console.WriteLine("Phone number: ");
        string phoneNumber = Console.ReadLine();

        Console.WriteLine("Fax number: ");
        string faxNumber = Console.ReadLine();

        Console.WriteLine("Web site: ");
        string webSite = Console.ReadLine();

        Console.WriteLine("Manager first name: ");
        string managerFirstName = Console.ReadLine();

        Console.WriteLine("Manager last name: ");
        string managerLastName = Console.ReadLine();

        Console.WriteLine("Manager age: ");
        string age = Console.ReadLine();
        int managerAge = new int();
        bool isAge = int.TryParse(age, out managerAge);

        Console.WriteLine("Manager phone: ");
        string managerPhone = Console.ReadLine();
        Console.WriteLine();

        if (isAge)
        {
            Console.WriteLine("Company name: " + companyName);
            Console.WriteLine("Company address: " + companyAddress);
            Console.WriteLine("Phone number: " + phoneNumber);
            Console.WriteLine("Fax number: " + faxNumber);
            Console.WriteLine("Web site: " + webSite);
            Console.WriteLine("Manager first name: " + managerFirstName);
            Console.WriteLine("Manager last name: " + managerLastName);
            Console.WriteLine("Manager age: " + managerAge);
            Console.WriteLine("Manager phone: " + managerPhone);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}
