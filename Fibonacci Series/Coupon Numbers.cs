using System;

namespace Coupon_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[6];
            Random random = new Random();
            //  Console.WriteLine(random.Next(chars.Length));

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            Console.WriteLine("Coupon Number Generated : " + finalString);
        }
    }
}
