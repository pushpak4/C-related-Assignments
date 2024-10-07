using System;
class PF
{
public static void Main()
{
int days;
int salary;
int ded;
int dedu;
int deu;
Console.WriteLine("Enter number of days present ");
days=Convert.ToInt32(Console.ReadLine());
salary = days * 5000;
Console.Write("Salary per month is "+salary);
Console.ReadLine();
ded = salary / 100  ;
deu = ded * 12 ;
Console.Write("Salary after PF percentage is "+deu);
Console.ReadLine();
dedu = salary - deu ;
Console.Write("Salary after PF deduction is "+dedu);
Console.ReadLine();
}
}