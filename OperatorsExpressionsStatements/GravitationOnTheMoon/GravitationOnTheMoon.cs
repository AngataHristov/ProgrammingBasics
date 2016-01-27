// Problem 2.	Gravitation on the Moon
// The gravitational field of the Moon is approximately 17% of that on the Earth.
// Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.WriteLine("Enter value for weight on the Earth: ");
        string input = Console.ReadLine();
        double weightOnEarth = new int();
        bool isNumber = double.TryParse(input, out weightOnEarth);
        if (isNumber)
        {
            if (weightOnEarth <= 0)
            {
                Console.WriteLine("Enter positive number, bigger than zero!");
                Main();
            }
            else
            {
                double weightOnMoon = (double)17 * weightOnEarth / 100;
                Console.WriteLine("The weight of a man on the moon is {0:F3}", weightOnMoon);
            }
        }
        else
        {
            Console.WriteLine("Invapid input!Enter a number!");
            Main();
        }
    }
}
