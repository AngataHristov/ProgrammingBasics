using System;

class BookOrders
{
    static void Main()
    {
        int numberOfOrders = int.Parse(Console.ReadLine());

        decimal totalCost = new decimal();
        int totalBooks = new int();

        for (int i = 0; i < numberOfOrders; i++)
        {
            int numberOfPackets = int.Parse(Console.ReadLine());
            int BooksPerPacket = int.Parse(Console.ReadLine());
            decimal bookPrice = decimal.Parse(Console.ReadLine());

            decimal fixedPrice = new decimal();
            int Books = numberOfPackets * BooksPerPacket;
            decimal cost = new decimal();

            if (numberOfPackets >= 10 && numberOfPackets <= 19)
            {
                fixedPrice = bookPrice - bookPrice * 0.05m;
            }
            if (numberOfPackets >= 20 && numberOfPackets <= 29)
            {
                fixedPrice = bookPrice - bookPrice * 0.06m;
            }
            if (numberOfPackets >= 30 && numberOfPackets <= 39)
            {
                fixedPrice = bookPrice - bookPrice * 0.07m;
            }
            if (numberOfPackets >= 40 && numberOfPackets <= 49)
            {
                fixedPrice = bookPrice - bookPrice * 0.08m;
            }
            if (numberOfPackets >= 50 && numberOfPackets <= 59)
            {
                fixedPrice = bookPrice - bookPrice * 0.09m;
            }
            if (numberOfPackets >= 60 && numberOfPackets <= 69)
            {
                fixedPrice = bookPrice - bookPrice * 0.10m;
            }
            if (numberOfPackets >= 70 && numberOfPackets <= 79)
            {
                fixedPrice = bookPrice - bookPrice * 0.11m;
            }
            if (numberOfPackets >= 80 && numberOfPackets <= 89)
            {
                fixedPrice = bookPrice - bookPrice * 0.12m;
            }
            if (numberOfPackets >= 90 && numberOfPackets <= 99)
            {
                fixedPrice = bookPrice - bookPrice * 0.13m;
            }
            if (numberOfPackets >= 100 && numberOfPackets <= 109)
            {
                fixedPrice = bookPrice - bookPrice * 0.14m;
            }
            if (numberOfPackets >= 110)
            {
                fixedPrice = bookPrice - bookPrice * 0.15m;
            }
            if (numberOfPackets < 10)
            {
                fixedPrice = bookPrice;
            }
            cost = Books * fixedPrice;

            totalCost += cost;
            totalBooks += Books;
        }

        Console.WriteLine(totalBooks);
        Console.WriteLine("{0:F2}", totalCost);
    }
}
