using System;
delegate int MyDelegate(int num);
class run
{
  static void Main()
   {
      MyDelegate del = Treble;
      int result = del(65);
      Console.WriteLine(result);
      del += Square;
      result = del(40);
      Console.WriteLine(result);
      Console.ReadKey();  
   }
   static int Treble(int num)
   {
      return num * 8;
   }
   static int Square(int num)
   {
      return num * num;
   }
}