using System;

class Budget
{
    static void Main()
    {
        double AllMoney = double.Parse(Console.ReadLine());
        int weekDayOut = int.Parse(Console.ReadLine());
        int weekendsInHome = int.Parse(Console.ReadLine());

        int rent = 150;
        int normalWeekends = 4 - weekendsInHome;
        int normalWeekendDays = normalWeekends * 2;
        double spendingForNormalWeekendDays = normalWeekendDays * 20;
        int normalDays = 30 - weekDayOut - normalWeekendDays - weekendsInHome * 2;

        double normalDaysSpending = normalDays * 10;
        double weekdayOutSpending = weekDayOut * (Math.Floor(((double)AllMoney / 100) * 3) + 10);

        double totalSpendMoney = weekdayOutSpending + spendingForNormalWeekendDays + rent + normalDaysSpending;

        if (AllMoney > totalSpendMoney)
        {
            Console.WriteLine("Yes, leftover {0}.", AllMoney - totalSpendMoney);
        }
        else if (AllMoney == totalSpendMoney)
        {
            Console.WriteLine("Exact Budget.");
        }
        else
        {
            Console.WriteLine("No, not enough {0}.", totalSpendMoney - AllMoney);
        }
    }
}
