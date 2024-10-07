using System;
namespace one 
{
	class one
	{
		static void Main(string[] args)
		{
			int x;
			int y;
			int result;
			Console.Write("Enter first number ");
			x=Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter second number ");
			y=Convert.ToInt32(Console.ReadLine());
			result = x % y;
			Console.Write("The number is "+result);
			Console.ReadLine();
		}
	}
}
	