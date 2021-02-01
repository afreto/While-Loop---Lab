using System;

namespace _02._Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string uName = Console.ReadLine();
            string uPass = Console.ReadLine();

            string password = Console.ReadLine();
            while (password != uPass)
            {
                password = Console.ReadLine();

            }
            Console.WriteLine($"Welcome {uName}!");
        }
    }
}

