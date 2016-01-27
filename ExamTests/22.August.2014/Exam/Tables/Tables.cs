using System;

class Tables
{
    static void Main()
    {
        long Bundle1 = long.Parse(Console.ReadLine());
        long Bundle2 = long.Parse(Console.ReadLine());
        long Bundle3 = long.Parse(Console.ReadLine());
        long Bundle4 = long.Parse(Console.ReadLine());

        long numberOfTableTops = long.Parse(Console.ReadLine());
        long needetTables = long.Parse(Console.ReadLine());

        long totalNumberOfLegs = Bundle1 * 1 + Bundle2 * 2 + Bundle3 * 3 + Bundle4 * 4;

        long possibleTablesByLegs = totalNumberOfLegs / 4;

        long restLegs = totalNumberOfLegs % 4;

        long possibleTablesByTops = numberOfTableTops;

        long posibleTables = Math.Min(possibleTablesByLegs, possibleTablesByTops);

        if (posibleTables > needetTables)
        {
            long restTops = numberOfTableTops - needetTables;

            Console.WriteLine("more: {0}", posibleTables - needetTables);

            Console.WriteLine("tops left: {0}, legs left: {1}", restTops, totalNumberOfLegs - needetTables * 4);
        }
        else if (posibleTables < needetTables)
        {
            Console.WriteLine("less: {0}", posibleTables - needetTables);

            long needetLegs = new int();

            if (totalNumberOfLegs <= needetTables * 4)
            {
                needetLegs = needetTables * 4 - totalNumberOfLegs;
            }

            Console.WriteLine("tops needed: {0}, legs needed: {1}", needetTables - posibleTables, needetLegs);
        }
        else if (posibleTables == needetTables)
        {
            Console.WriteLine("Just enough tables made: {0}", posibleTables);
        }
    }
}
