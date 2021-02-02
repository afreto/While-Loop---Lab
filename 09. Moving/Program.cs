using System;

namespace _09._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int area = width * length * height;
            int boxes = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input != "Done")
                {
                    boxes += int.Parse(input);
                    if (boxes > area)
                    {
                        Console.WriteLine($"No more free space! You need {boxes - area} Cubic meters more.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"{area - boxes} Cubic meters left.");
                    break;
                }
            }
        }
    }
}