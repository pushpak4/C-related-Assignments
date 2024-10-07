using System;    //giving system as namespace
class pushpak        //using class as pushpak
{
	public static void Main()          //method starts
	{
		int r,p;                            //giving r as first number and p as second number 
		int[] numbers = new int[10] {0,1,2,4,6,3,5,7,8,9};          //declaring array number
		Console.Write("Target number: ");
		string number=Console.ReadLine();
	   int target_number=int.Parse(number); 
		for(r=0;r<10;r++)                    //first number
		{
			for(p=1;p<10;p++)                    //second number
			{
				int sum=numbers[r]+numbers[p];  // checking the target number of their sum
				if(sum == target_number) 
				{
	Console.WriteLine("The sum of "+numbers[r]+" and "+numbers[p]+" is target number");     //for the display of target number
				}  
			}
	    }	
	}
}
