// Programmer: Omar Fuentes
// Project: Week 3-2
// Date: 01/28/2020
// Description: Working with Iterative Statements
using System;

namespace IterativeStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input.
            Console.WriteLine("Enter an Integer value between 1 and 100 to execute a For Loop: ");
            // Validate user input.
            try
            {
                // This variable will gather data from user input 
                string input = Console.ReadLine();

                // This variable will be used to perform the various iterative statements and is parsed as an integer
                int valueOfInput = int.Parse(input);

                /* 
                This conditional IF/ELSE IF/ELSE statement is used to test the values of user input.
                Depending on the value of the user input between 1 and 100, a For Loop iterative statement will execute. 
                */
                if ((valueOfInput >= 1) && (valueOfInput <= 100))
                {
                    Console.WriteLine("The For Loop will iterate " + valueOfInput.ToString() + " times.");
                }


                // Here is the For Loop
                for (int x = 1; x <= valueOfInput; x++)

                    // If the value of user input is between 1 and 100, execute a For Loop
                    if ((valueOfInput >= 1) && (valueOfInput <= 100))


                    {
                        Console.WriteLine("You have entered" + valueOfInput.ToString() + "." + " This is the current integer value in the loop: " + x.ToString());
                    }

                // Pause the program.
                Console.ReadKey(true);

            }
            // Display an error message if invalid input is entered.
            catch
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey(true);
            }
        }
    }
}
