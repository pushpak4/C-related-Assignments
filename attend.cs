using System;
class attend
{
public static void attend()
{
int days;
int attend;
Console.WriteLine("Enter number of days present ");
days=Convert.ToInt32(Console.ReadLine());
attend = days * 100 / 30;
Console.Write("Number of days present precentage is "+attend);
Console.ReadLine();
}
}
