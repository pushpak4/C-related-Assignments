class computing
{
  public void Display()
  {
     System.Console.WriteLine("computing");
  }
}

class department : computing
{
  new public void Display()
  {
     System.Console.WriteLine("department");
  }
}

class course
{
  public static void Main()
  {
     computing c = new computing();
     c.Display();    
  }
}