using System;
class temp
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
	  string temp = Console.ReadLine();
int temperature = int.Parse(temp);
if(temperature<21)
{
Console.WriteLine("Too cold!");
}
else if(temperature < 23) {
Console.WriteLine("Just right.");
}
else {
Console.WriteLine("Too hot!");
}
}   
}