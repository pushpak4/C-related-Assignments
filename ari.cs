using System;    //giving the namespace as system
class pushpak {
 public static void Main() {
   double myNan = Double.NaN;
   try {
     Math.Sign(myNan);
   }
   catch (ArithmeticException e) {
     Console.WriteLine("Error: {0}",e);
   }
 }
}
