using System;
interface IA
{
void show();
}
interface IB
{
void display();
}
public class subclass:IA,IB
{
public void show()
{
Console.WriteLine("method");
}
public void display()
{
Console.WriteLine("display");
}
}
class demo
{
public static void Main()
{
subclass s1=new subclass();
s1.show();
s1.display();
IA i1=new subclass();
i1.show();
IB i2=new subclass();
i2.display();
}
}


