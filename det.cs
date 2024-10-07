using System;
class push
{
public static void Main()
{
int i,j,m,n;
Console.WriteLine("enter rows and columns");
m = Convert.ToInt32(Console.ReadLine());
n = Convert.ToInt32(Console.ReadLine());
double[,]A = new double[10,10];
Console.WriteLine("enter the matrix");
for(i=0;i<m;i++)
{
for(j=0;j<n;j++)
{
A[i,j] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine();
}
double det=0;
for(i=0;i<3;i++)
det = det + (A[0,i]*(A[1,(i+1)%3]*A[2,(i+2)%3] - A[1,(i+2)%3]*A[2,(i+1)%3]));
Console.Write("Determinant is:"+det);
Console.ReadLine();
}
}
