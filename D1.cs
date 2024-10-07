using System;
namespace EmployeeDetails
{
class employee
{
public int emp_id;
public string emp_name;
public int emp_age;
public string emp_desg;
public int emp_sal;

public void InputDetails()
{

Console.WriteLine("Enter Your Name: ");
emp_name=Console.ReadLine();
Console.WriteLine("Enter Your ID: ");
emp_id=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Your Age: ");
emp_age=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Your Designation: ");
emp_desg=Console.ReadLine();
Console.WriteLine("Enter Salary: ");
emp_sal=Convert.ToInt32(Console.ReadLine());
	
}
public void PfDeduction()
{
	double final_salary;
	double net_salary;
	int sal_att;
	double hra= 4000;
	double ma = 3500;
	double da = 3350;
	net_salary = emp_sal+hra+ma+da;
	double pf= net_salary*0.12;
	final_salary = net_salary-pf;
	Console.WriteLine("<<<Salary after allowances is>>>: " +net_salary);
	Console.WriteLine("<<<Salary after PF deduction is>>>: " +final_salary);
	Console.WriteLine("<<<Enter the number of days absent>>>: ");
    int days= Convert.ToInt32(Console.ReadLine());
	if (emp_desg=="ceo" || emp_desg=="md" || emp_desg=="gm")
	{
		sal_att = (days)*7000;
		Console.WriteLine("***salary cut for CEO or MD or GM per day is 7000***");
	}
	else 
	{
		sal_att = days*2000;
		Console.WriteLine("***salary cut for employees per day is 2000***");
	}
	double salatt= final_salary-sal_att;
	Console.WriteLine("<<<Salary after attendance deduction is>>>: " +salatt);
}

}
class demo
{
	public static void Main()
	{
		employee e1=new employee();
		e1.InputDetails();
		e1.PfDeduction();
		
		
		
	}
}

}