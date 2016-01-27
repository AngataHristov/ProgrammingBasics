using System;

class TorrentPirate
{
    static void Main()
    {
        // int d = Int32.Parse(Console.ReadLine());
        // int p = Int32.Parse(Console.ReadLine());
        // int w = Int32.Parse(Console.ReadLine());
        // 
        // double downloadTime = (double)d / 2 / 60 / 60;
        // double costAtMall = downloadTime * w;
        // double numberOfMovies = (double)d / 1500;
        // double costAtCinema = numberOfMovies * p;
        // 
        // if (costAtMall > costAtCinema)
        // {
        //     Console.WriteLine("cinema -> {0:0.00}lv", costAtCinema);
        // }
        // else
        // {
        //     Console.WriteLine("mall -> {0:0.00}lv", costAtMall);
        // }
        int d = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int w = int.Parse(Console.ReadLine());

        int OneMovieSize = 1500;
        int downloadSpeed = 2;
        double downloadTime = (double)d / downloadSpeed / 60 / 60;
        decimal priceForDownload = (decimal)downloadTime * w;
        double numberOfMoviesDownloaded = (double)d / OneMovieSize;
        decimal cinemaPrice = (decimal)numberOfMoviesDownloaded * p;

        if (Math.Round(priceForDownload,0) > cinemaPrice)
        {
            Console.WriteLine("cinema -> {0:F2}lv", cinemaPrice);
        }
        else
        {
            Console.WriteLine("mall -> {0:F2}lv", priceForDownload);
        }
    }
}
