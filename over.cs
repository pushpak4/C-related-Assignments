using System;
 
namespace Function_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.sum();
            Calculator.sum(5,4);
            Calculator.sum(9.3f, 8.6f);
            Calculator.sum("Hello World");
            Console.Read();
        }
    }
    static class Calculator
    {
        public static void sum()
        {
            Console.WriteLine("No Value Provided");
        }
        public static void sum(int x, int y)
        {
            Console.WriteLine("Sum of {0} and {1} is {2}", x, y, (x + y));
        }
        public static void sum(float x, float y)
        {
            Console.WriteLine("Sum of {0} and {1} is {2}", x, y, (x + y));
        }
        public static void sum(string s)
        {
            Console.WriteLine("{0} - is not a numeric value", s);
        }
    }
}