using System;
class person
{
	public string address;
	public string name;
	public person(string uaddress,string uname)
	{
		address=uaddress;
		name=uname;
	}
}
class one
{
	public static void Main()
	{
		person p1=new person("navalur","one");
		person p2=new person("warangal","two");
		Console.WriteLine(p1.address);
		Console.WriteLine(p1.name);
		Console.WriteLine(p2.address);
		Console.WriteLine(p2.name);
	}
}
