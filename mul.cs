using System;
 
namespace Multiple
{
    interface shail
    {
        int add(int a, int b);
    }
    interface room
    {
        int sub(int x, int y);
    }
    class play : shail, room
    {
        public int result;
        public int add(int a, int b)
        {
            return result = a + b;
        }
        public int result1;
        public int mul(int x, int y)
        {
            return result1 = x * y;
        }
 
        class computer
        {
            static void Main(string[] args)
            {
                play c = new play();
                c.add(1000, 500);
                c.sub(85, 60);
                Console.WriteLine("Multiple Inheritance concept Using Interfaces :\n ");
                Console.WriteLine("Addition: " + c.result);
                Console.WriteLine("Multiplication: " + c.result1);
                Console.ReadKey();
            }
        }
    }
}
 
