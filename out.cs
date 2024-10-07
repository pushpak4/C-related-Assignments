using System;

class Program
{
    static void Main()
    {
        // Demonstrate the argument null exception.
        try
        {
            A(null);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
        // Demonstrate the general argument exception.
        try
        {
            A("");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
        // Flow path without exception.
        Console.WriteLine(A("test"));
    }

    static int A(string argument)
    {
        // Handle null argument.
        if (argument == null)
        {
            throw new ArgumentNullException("argument");
        }
        // Handle invalid argument.
        if (argument.Length == 0)
        {
            throw new ArgumentException("Zero-length string invalid", "argument");
        }
        return argument.Length;
    }
}