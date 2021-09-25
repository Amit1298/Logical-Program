using System;

namespace bineryConvetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter to Number : ");
            int value = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(value, 2);
            Console.WriteLine(binary);
        }
    }
}
