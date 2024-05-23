using System;


class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("the number 2 times the entered number equals to: " + Tavan(number));
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
    public static int Tavan(int number)
    {
        if (number == 0)
        {
            return 1;
        }
        else
        {
           return 2 * Tavan(number - 1);
        }
    }
}