using System;

class Firefighting
{
    static void Main()
    {
        int numberOfFirefighters = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();

        int totalKids = new int();
        int totalAdults = new int();
        int totalSeniors = new int();

        while (input != "rain")
        {
            int kids = new int();
            int adults = new int();
            int seniors = new int();

            char[] currentBuilding = input.ToCharArray();

            for (int i = 0; i < currentBuilding.Length; i++)
            {
                if (kids >= numberOfFirefighters)
                {
                    break;
                }
                if (currentBuilding[i] == 'K')
                {
                    kids++;
                }
            }

            for (int i = 0; i < currentBuilding.Length; i++)
            {
                if (adults >= numberOfFirefighters - kids)
                {
                    break;
                }
                if (currentBuilding[i] == 'A')
                {
                    adults++;
                }
            }
            for (int i = 0; i < currentBuilding.Length; i++)
            {
                if (seniors >= numberOfFirefighters - kids - adults)
                {
                    break;
                }
                if (currentBuilding[i] == 'S')
                {
                    seniors++;
                }
            }
            totalKids += kids;
            totalAdults += adults;
            totalSeniors += seniors;
            input = Console.ReadLine();
        }
        Console.WriteLine("Kids: {0}",totalKids);
        Console.WriteLine("Adults: {0}", totalAdults);
        Console.WriteLine("Seniors: {0}", totalSeniors);
    }
}
