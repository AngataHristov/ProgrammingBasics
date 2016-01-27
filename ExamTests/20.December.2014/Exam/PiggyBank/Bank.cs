using System;

class Bank
{
    static void Main()
    {
        double priceOFTank = double.Parse(Console.ReadLine());
        int numberOfPartyDaysInMounth = int.Parse(Console.ReadLine());

        int spendMoneyForPartyDaysInMonth = 5 * numberOfPartyDaysInMounth;
        int saveMoneyForMounth = (((30 - numberOfPartyDaysInMounth) * 2) - spendMoneyForPartyDaysInMonth);

        if (saveMoneyForMounth <= 0)
        {
            Console.WriteLine("never");
        }
        else
        {
            double result = priceOFTank / saveMoneyForMounth;
            int totalMonths = (int)Math.Ceiling(result);
            double years = totalMonths / 12;
            double months = totalMonths % 12;

            Console.WriteLine("{0} years, {1} months", years, Math.Ceiling(months));
        }
    }
}
