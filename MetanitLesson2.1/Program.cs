using System;

namespace MetanitLesson2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter deposit amount: ");
            decimal deposit = decimal.Parse(Console.ReadLine());
            Console.Write("Enter the quantity of months: ");
            int months = int.Parse(Console.ReadLine());

            for (int i = 0; i < months; i++)
            {
                deposit += deposit * 0.07M;
            }
            Console.WriteLine($"The final amount is {deposit}");

            Console.ReadLine();
        }
    }
}
