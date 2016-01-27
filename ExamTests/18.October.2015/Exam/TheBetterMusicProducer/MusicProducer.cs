using System;

class MusicProducer
{
    static void Main()
    {
        int numbOfAlbInEuropa = int.Parse(Console.ReadLine());
        double priceInEuro = double.Parse(Console.ReadLine());

        int numbOfAlbInNorthAmerica = int.Parse(Console.ReadLine());
        double priceInDollars = double.Parse(Console.ReadLine());

        int numbOfAlbInSouthAmerica = int.Parse(Console.ReadLine());
        double priceInPesos = double.Parse(Console.ReadLine());

        int numberOfConcerts = int.Parse(Console.ReadLine());
        double profitFromSingleConcerInEuro = double.Parse(Console.ReadLine());

        double Europa = (double)numbOfAlbInEuropa * priceInEuro * 1.94;
        double northAmerica = (double)numbOfAlbInNorthAmerica * priceInDollars * 1.72;
        double southAmerica = (double)numbOfAlbInSouthAmerica * priceInPesos / 332.74;
        double AllAlbums = Europa + northAmerica + southAmerica;
        double forProducer = AllAlbums * 0.35;
        double taxes = (AllAlbums - forProducer) * 0.2;
        double albumsProfit = AllAlbums - forProducer - taxes;

        double concertProfit = (double)numberOfConcerts * profitFromSingleConcerInEuro * 1.94;

        if (concertProfit > 100000)
        {
            concertProfit = concertProfit - concertProfit * 0.15;
        }
        if (albumsProfit > concertProfit)
        {
            Console.WriteLine("Let's record some songs! They'll bring us {0:F2}lv.", albumsProfit);
        }
        else
        {
            Console.WriteLine("On the road again! We'll see the world and earn {0:F2}lv.", concertProfit);
        }
    }
}
