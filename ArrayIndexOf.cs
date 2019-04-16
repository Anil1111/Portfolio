/*
   Source: https://www.dotnetperls.com/array
   Author: Sam Allen
   Summary: This program demonstrates IndexOf method.
   Date: 13 Apr 2019
   Modifications: ----
   Example Output:
                    abcd
                    bc
*/

using System;

class Program
{
    static void Main()
    {
        string[] array = { "cat", "dog", "bird", "fish" };

        // The dog string is at index 1.
        int dogIndex = Array.IndexOf(array, "dog");
        Console.WriteLine(dogIndex);

        // There is no monkey string in the array.
        // ... So IndexOf returns -1.
        int monkeyIndex = Array.IndexOf(array, "monkey");
        Console.WriteLine(monkeyIndex);
    }
}
