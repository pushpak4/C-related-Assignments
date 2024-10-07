using System;
 
namespace MultipleInheritApplication
{
    interface calc1
    {
        int add(int a, int b);
    }
    interface calc2
    {
        int sub(int x, int y);
    }
    class Calculation : calc1, calc2
    {
        public int result1;
        public int add(int a, int b)
        {
            return result1 = a + b;
        }
        public int result2;
        public int sub(int x, int y)
        {
            return result2 = x - y;
        }
 
        class maths
        {
            static void Main(string[] args)
            {
                Calculation c = new Calculation();
                c.add(80, 20);
                c.sub(50, 25);
                Console.WriteLine("Multiple Inheritance concept Using Interfaces :\n ");
                Console.WriteLine("Addition: " + c.result1);
                Console.WriteLine("Substraction: " + c.result2);
                Console.ReadKey();
            }
        }
    }
}
 
