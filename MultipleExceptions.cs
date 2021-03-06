/*
   Source: https://www.sanfoundry.com/csharp-program-multiple-exceptions/
   Author: Manish Bhojasia
   Summary: This program retrieves demonstrates various exceptions that occur
            when user input is invalid, by employing the try-catch and the switch
            statement.
   Date: 5 Apr 2019
   Modifications: Added restart function to the program.
   Example Output:
                    Enter Your First Number : 10
                    Enter an Operator  (+, -, * or /) : ,
                    Operation Error : , is not a Valid Operator
 */
using System;
class Exercise
{
    static void Main()
    {
        double Num1, Num2;
        double Result = 0.00;
        char op;
        bool runProgram = true;

        // The original program would terminate following an exception
        // or if the operation was successful. runProgram was
        // added to ask if the user would like to restart or exit the
        // program.

        // By using the while loop, the program will continue to loop
        // through until the user inputs E at the end of the program.
        while (runProgram)
        {
            try
            {
                Console.Write("Enter your First Number :  ");
                Num1 = double.Parse(Console.ReadLine());
                Console.Write("Enter an Operator  (+, -, * or /): ");
                op = char.Parse(Console.ReadLine());
                if (op != '+' && op != '-' &&
                    op != '*' && op != '/')
                    throw new Exception(op.ToString());

                Console.Write("Enter your Second Number :");
                Num2 = double.Parse(Console.ReadLine());

                if (op == '/')
                    if (Num2 == 0)
                        throw new DivideByZeroException("Division by zero is not allowed");


                Result = Calculator(Num1, Num2, op);
                Console.WriteLine("\n{0} {1} {2} = {3}", Num1, op, Num2, Result);


            }

            catch (FormatException)
            {
                Console.WriteLine("The number you typed is not valid");


            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Operation Error: {0} is not a valid op", ex.Message);

            }

            // The runProgram will return boolean false to bring the program
            // out of the loop.
            runProgram = false;
            Console.WriteLine("Would you like to restart or exit? (R/E)");
            char userResponse = char.Parse(Console.ReadLine());
            if (userResponse == 'R')
            {
                Console.Clear();
                runProgram = true;
            }
            else if (userResponse == 'E')
            {
                Console.ReadKey();
            }
        }
    }

    static double Calculator(double v1, double v2, char op)
    {
        double Result = 0.00;
        switch (op)
        {
            case '+':
                Result = v1 + v2;
                break;
            case '-':
                Result = v1 - v2;
                break;
            case '*':
                Result = v1 * v2;
                break;
            case '/':
                Result = v1 / v2;
                break;
        }
        return Result;
    }
}
