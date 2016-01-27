using System;
using System.Linq;

class Airlines
{
    static void Main()
    {
        int[] firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] secondtLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] thirdtLine = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int firstClassPassengers = firstLine[0];
        int bussinesClassPassengers = secondtLine[0];
        int economyClassPassengers = thirdtLine[0];

        int firstClassFrequentFlyers = firstLine[1];
        int bussinesClassFrequentFlyers = secondtLine[1];
        int economyClassFrequentFlyers = thirdtLine[1];

        int firstClassPurchases = firstLine[2];
        int bussinesClassPurchases = secondtLine[2];
        int economyClassPurchases = thirdtLine[2];

        int firstClassProfit = (int)((firstClassPassengers - firstClassFrequentFlyers - firstClassPurchases) * 7000 + (int)firstClassFrequentFlyers * (7000 - 7000 * 0.7) + (int)firstClassPurchases * (7000 + 7000 * 0.005));
        int bussinesClassProfit = (int)((bussinesClassPassengers - bussinesClassFrequentFlyers - bussinesClassPurchases) * 3500 + (int)bussinesClassFrequentFlyers * (3500 - 3500 * 0.7) + (int)bussinesClassPurchases * (3500 + 3500 * 0.005));
        int economyClassProfit = (int)((economyClassPassengers - economyClassFrequentFlyers - economyClassPurchases) * 1000 + (int)economyClassFrequentFlyers * (1000 - 1000 * 0.7) + (int)economyClassPurchases * (1000 + 1000 * 0.005));

        int totalProfit = firstClassProfit + bussinesClassProfit + economyClassProfit;

        int firstClassMaxProfit = (int)(12 * (7000 + 7000 * 0.005));
        int bussinesClassMaxProfit = (int)(28 * (3500 + 3500 * 0.005));
        int economyClassMaxProfit = (int)(50 * (1000 + 1000 * 0.005));

        int totalMaxProfit = firstClassMaxProfit + bussinesClassMaxProfit + economyClassMaxProfit;

        Console.WriteLine((int)totalProfit);
        Console.WriteLine((int)(totalMaxProfit - totalProfit));

    }
}
