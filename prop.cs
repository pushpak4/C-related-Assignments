using System;
namespace one {
   class Student {
      private string name = "not known";
      private int age = 0;
      public string Name {
         get {
            return name;
         }
         set {
            name = value;
         }
      }
      public int Age {
         get {
            return age;
         }
         set {
            age = value;
         }
      }
      public override string ToString() {
         return "Name = " + Name + ", Age = " + Age;
      }
   }
   class Demo {
      public static void Main() {
         Student s = new Student();
         s.Name = "Zara";
         s.Age = 9;
         Console.WriteLine("Student Info: {0}", s);
         Console.ReadKey();
      }
   }
}