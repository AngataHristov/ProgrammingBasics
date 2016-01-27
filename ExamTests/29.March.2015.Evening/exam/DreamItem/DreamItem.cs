using System;
using System.Linq;

class DreamItem
{
    public static int NumberOfDaysInMonth(string month)
    {
        int numberOfDays = new int();
        switch (month)
        {
            case "Jan":
                numberOfDays = 31;
                break;
            case "Feb":
                numberOfDays = 28;
                break;
            case "March":
                numberOfDays = 31;
                break;
            case "Apr":
                numberOfDays = 30;
                break;
            case "May":
                numberOfDays = 31;
                break;
            case "June":
                numberOfDays = 30;
                break;
            case "July":
                numberOfDays = 31;
                break;
            case "Aug":
                numberOfDays = 31;
                break;
            case "Sept":
                numberOfDays = 30;
                break;
            case "Oct":
                numberOfDays = 31;
                break;
            case "Nov":
                numberOfDays = 30;
                break;
            case "Dec":
                numberOfDays = 31;
                break;
            default:
                break;
        }
        return numberOfDays;
    }
    static void Main()
    {
        string[] input = Console.ReadLine().Split('\\');
        string month = input[0];
        decimal moneyPerHour = decimal.Parse(input[1]);
        int hoursPrerDay = int.Parse(input[2]);
        decimal dreamItemPrice = decimal.Parse(input[3]);

        int workingDaysPerMonth = NumberOfDaysInMonth(month) - 10;
        decimal moneyForDay = moneyPerHour * hoursPrerDay;
        decimal moneyForMonth = moneyForDay * workingDaysPerMonth;

        if (moneyForMonth > 700)
        {
            moneyForMonth += moneyForMonth * 0.1M;
        }
        if (moneyForMonth >= dreamItemPrice)
        {
            decimal rest = moneyForMonth - dreamItemPrice;
            Console.WriteLine("Money left = {0:F2} leva.", rest);
        }
        else
        {
            decimal neededMoney = dreamItemPrice - moneyForMonth;
            Console.WriteLine("Not enough money. {0:F2} leva needed.", neededMoney);
        }
    }
}
