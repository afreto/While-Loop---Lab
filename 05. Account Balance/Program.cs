using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalMoney = 0;
            double sum = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "NoMoreMoney")
                {
                    Console.WriteLine($"Total: {totalMoney:f2}");
                    break;
                }
                else
                {
                    sum = double.Parse(input);
                    if (sum < 0)
                    {
                        Console.WriteLine("Invalid operation!");
                        Console.WriteLine($"Total: {totalMoney:f2}");
                        break;
                    }
                    totalMoney += sum;
                }
                Console.WriteLine($"Increase: {sum:f2}");
            }
        }
    }
}
