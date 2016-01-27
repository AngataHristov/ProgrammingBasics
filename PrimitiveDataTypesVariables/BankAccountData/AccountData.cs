// Problem 11.	Bank Account Data
// A bank account has a holder name(first name, middle name and last name), available amount of money(balance),
// bank name, IBAN, 3 credit card numbers associated with the account.Declare the variables needed to keep the
// information for a single bank account using the appropriate data types and descriptive names.

using System;

class AccountData
{
    static void Main()
    {
        string customerFirstName;
        string customerMiddleName;
        string customerLastName;
        decimal moneyBalance;
        string bankName;
        string IBAN;
        ulong creditCardNumberOne;
        ulong creditCardNumberTwo;
        ulong creditCardNumberThree;

        customerFirstName = "Angel";
        customerMiddleName = "Georgiev";
        customerLastName = "Hristov";
        moneyBalance = 0.000m;
        bankName = "DSK";
        IBAN = "BG00 XXXX 0000 0000 0000 00";
        creditCardNumberOne = 3534567890123456789u;
        creditCardNumberTwo = 9834567890123656789u;
        creditCardNumberThree = 9234567890323453489u;

        Console.WriteLine("{0} {1} {2}" + "\n" + "Balance: {3} USD" + "\n" + "Bank: {4}" + "\n" + "IBAN: {5}" +
            "\n" + "Credit Card Number 1: {6}" + "\n" + "Credit Card Number 2: {7}" + "\n" +
            "Credit Card Number 3: {8}", customerFirstName, customerMiddleName, customerLastName,
            moneyBalance, bankName, IBAN, creditCardNumberOne, creditCardNumberTwo, creditCardNumberThree);
        Console.WriteLine();
    }
}
