using System;

namespace _08._Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int clas = 0;
            double annualGrade = 0;
            int exclude = 0;
            while (clas < 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade < 4)
                {
                    exclude++;
                }
                if (exclude >= 2)
                {
                    Console.WriteLine($"{name} has been excluded at {clas} grade");
                    break;
                }
                annualGrade += grade;
                clas++;
            }
            if (exclude < 2)
            {
                Console.WriteLine($"{name} graduated. Average grade: {annualGrade / clas:f2}");
            }
        }
    }
}
