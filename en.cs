using System;
struct Books {
   private string title;
   private int book_id;
   public void getValues(string t, int id) {
      title = t;
      book_id = id;
   }
   public void display() {
      Console.WriteLine("Title : {0}", title);
      Console.WriteLine("Book_id :{0}", book_id);
   }
};  
public class testStructure {
   public static void Main(string[] args) {
      Books Book1 = new Books();
      Book1.getValues("C Programming", 6495407);
      Book1.display();
      Console.ReadKey();
   }
}