using System;

namespace Reverse_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, Reverse = 0, Rem;
            Console.WriteLine("Enter number: ");
            number = int.Parse(Console.ReadLine());
            while (number != 0)
            {
                Rem = number % 10;
                Reverse = Reverse * 10 + Rem;
                number /= 10;
            }
            Console.WriteLine("Reversed Number : " + Reverse);
            Console.ReadLine();
        }
    }
}
