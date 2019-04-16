/*
   Source: https://www.dotnetperls.com/constructor
   Author: Sam Allen
   Summary: This program demonstrates how to use the Base
            keyword to allow the derived constructor to invoke
            the base class constructor.
   Date: 13 Apr 2019
   Modifications: Changed the original int values and renamed
                  variables to demonstrate strings can also be used.
   Example Output:
                    Box contains present
                    Ribbon is wrapped with present
                    :::DONE:::
 */

using System;

public class Box
{
    public Box(string surprise)
    {
        Console.WriteLine($"Box contains {surprise}");
    }
}

public class Ribbon : Box
{
    public Ribbon(string surprise) : base(surprise)
    {
        Console.WriteLine($"Ribbon is wrapped with {surprise}");
    }
}

class Program
{
    static void Main()
    {
        // 
        Ribbon ribbon = new Ribbon("present");
        Console.WriteLine(":::DONE:::");
    }
}
