using System;
namespace pushpak
{
    class one
    {
        public static void Main()
        {
            Console.Write("Enter a Number : ");
            int number;
            number = Convert.ToInt32(Console.ReadLine());
            int x;
            x = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    x++;
                }
            }
            if (x == 2)
            {
                Console.WriteLine("Number is a Prime Number and the Largest Factor is {0}",number);
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
            Console.ReadLine();
        }
    }
}