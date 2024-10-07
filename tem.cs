public class temp
{	
enum Temperature                     //declaring enum
        {
            Low,
            Medium,
            High,
        };
public static void  Main() 
{	
      Console.WriteLine("Enter the temperature: ");
	  string tem=Console.ReadLine();
	  int temp=int.Parse(tem);
	       if(temp<97)
	   {
		   Console.WriteLine(Temperature.Low);       //calling enum
	   }
           if(temp>97 && temp<100)                         //if statement
	   {
		   Console.WriteLine(Temperature.Medium);        //calling enum
	   }  
           if(temp>100)
	   {
		   Console.WriteLine(Temperature.High);             //calling enum
	   }	   
}
}
