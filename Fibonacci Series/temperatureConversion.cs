using System;

namespace TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit;

            double celsius;
            Console.Write("Enter the value of Celsius : ");

            celsius = double.Parse(Console.ReadLine());
            Console.WriteLine("Celsius: " + celsius);

            fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("Fahrenheit: " + fahrenheit);


            Console.Write("Enter the value of Fehrenheit : ");
            fahrenheit = double.Parse(Console.ReadLine());
            Console.WriteLine("fahrenheit: " + fahrenheit);

            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("celsius: " + celsius);
            Console.ReadLine();
        }
    }
}
