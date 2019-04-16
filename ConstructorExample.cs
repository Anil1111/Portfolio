/*
   Source: https://www.dotnetperls.com/constructor
   Author: Sam Allen
   Summary: This program demonstrates how to use the Base
            keyword to allow the derived constructor to invoke
            the base class constructor.
   Date: 13 Apr 2019
   Modifications: ----
   Example Output:
                    Bird() called with 450
                    Parrot called with 450
                    :::DONE:::
 */

using System;

public class Bird
{
    public Bird(int value)
    {
        Console.WriteLine($"Bird() called with {value}");
    }
}

public class Parrot : Bird
{
    public Parrot(int value) : base(value)
    {
        Console.WriteLine($"Parrot called with {value}");
    }
}

class Program
{
    static void Main()
    {
        Parrot parrot = new Parrot(450);
        Console.WriteLine(":::DONE:::");
    }
}
