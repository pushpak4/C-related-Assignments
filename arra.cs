using System;

namespace Error {

   class Div {
      int res;
      
      Div() {
         res = 0;
      }
      
      public void division(int number1, int number2) {
         try {
            res = number1 / number2;
         } catch (DivideByZeroException e) {
            Console.WriteLine("Exception caught: {0}", e);
         } finally {
            Console.WriteLine("Result: {0}", res);
         }
      }
      
      static void Main(string[] args) {
         Div d = new Div();
         d.division(25, 0);
         Console.ReadKey();
      }
   }
}
