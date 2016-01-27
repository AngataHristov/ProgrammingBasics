using System;

class Torrents
{
    static void Main()
    {
        int d = int.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());
        double w = double.Parse(Console.ReadLine());

        double downloadingTime = (double)d / 2 / 60 / 60;
        double priceForDownloading = (double)downloadingTime * w;
        double numOfDownloadetMovies = (double)d / 1500;
        double cinemaPrice = (double)numOfDownloadetMovies * p;

        if (priceForDownloading <= cinemaPrice)
        {
            Console.WriteLine("mall -> {0:F2}lv", priceForDownloading);
        }
        else
        {
            Console.WriteLine("cinema -> {0:F2}lv", cinemaPrice);
        }
    }
}
