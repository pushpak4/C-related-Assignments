public class pushpak
{	
enum temp                    
        {
            Low,
            Medium,
            High,
        };
public static void  Main() 
{	
      Console.Write("Enter temperature: ");
	  string tempa=Console.ReadLine();
	  int tempa=int.Parse(tempa);
	       if(tempa<50)
	   {
		   Console.Write(temp.Low);       
	   }
            else if(tempa>50 && tempa<70)                         
	   {
		   Console.Write(temp.Medium);       
	   }  
           else(tempa>70)
	   {
		   Console.Write(temp.High);           

	   }	   
}
}
