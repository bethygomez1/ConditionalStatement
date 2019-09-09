/*
 Author: Bethy Gomez
 Date: 9/9/2019
 Description: Deliverable 2 - Conditional Statement
 */

using System;

namespace ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input
            Console.WriteLine("Please enter the grade you expect to receive in ISM 4300.");
            Console.WriteLine();
            Console.WriteLine("Be sure to enter a value that is between 0 and 100.");
            
            try
            {
                // This variable will gather the user input
                int grade = int.Parse(Console.ReadLine());

                // These if, else/if statements will use the user input to determine a letter grade
                if ((grade >= 98) && (grade <= 100)) // 98-100 is an A+
                {
                    Console.WriteLine("You should expect to receive an A+ in the class");
                    Console.WriteLine();
                    Console.WriteLine("Please press any key to continue...");
                    Console.ReadKey(true);
                }
                else if ((grade >= 92) && (grade <= 97)) // 92-27 is an A
                {
                    Console.WriteLine("You should expect to receive an A in the class");
                    Console.WriteLine();
                    Console.WriteLine("Please press any key to continue...");
                    Console.ReadKey(true);
                }
                else if ((grade >= 90) && (grade <= 91)) // 90-91 is an A-
                {
                    Console.WriteLine("You should expect to receive an A- in the class");
                    Console.WriteLine();
                    Console.WriteLine("Please press any key to continue...");
                    Console.ReadKey(true);
                }
                else if ((grade >= 88) && (grade <= 89)) // 88-89 is a B+
                {
                    Console.WriteLine("You should expect to receive an B+ in the class");
                    Console.WriteLine();
                    Console.WriteLine("Please press any key to continue...");
                    Console.ReadKey(true);
                }
                else if ((grade >= 82) && (grade <= 87)) // 82-87 is a B
                {
                    Console.WriteLine("You should expect to receive an B in the class");
                    Console.WriteLine();
                    Console.WriteLine("Please press any key to continue...");
                    Console.ReadKey(true);
                }
                else if ((grade >= 80) && (grade <= 81)) // 80-81 is a B-
                {
                    Console.WriteLine("You should expect to receive an B- in the class");
                    Console.WriteLine();
                    Console.WriteLine("Please press any key to continue...");
                    Console.ReadKey(true);
                }
                else if ((grade >= 78) && (grade <= 79)) // 78-79 is a C+
                {
                    Console.WriteLine("You should expect to receive an C+ in the class");
                    Console.WriteLine();
                    Console.WriteLine("Please press any key to continue...");
                    Console.ReadKey(true);
                }
                else if ((grade >= 72) && (grade <= 77)) // 72-77 is a C
                {
                    Console.WriteLine("You should expect to receive an C in the class");
                    Console.WriteLine();
                    Console.WriteLine("Please press any key to continue...");
                    Console.ReadKey(true);
                }
                else if ((grade >= 70) && (grade <= 71)) // 70-71 is a C-
                {
                    Console.WriteLine("You should expect to receive an C- in the class");
                    Console.WriteLine("Please be aware that this is not a passing grade and you may need to retake the class");
                    Console.WriteLine();
                    Console.WriteLine("Please press any key to continue...");
                    Console.ReadKey(true);
                }
                else if ((grade >= 68) && (grade <= 69)) // 68-69 is a D+
                {
                    Console.WriteLine("You should expect to receive an D+ in the class");
                    Console.WriteLine("Please be aware that this is not a passing grade and you may need to retake the class");
                    Console.WriteLine();
                    Console.WriteLine("Please press any key to continue...");
                    Console.ReadKey(true);
                }
                else if ((grade >= 62) && (grade <= 67)) // 62-67 is a D
                {
                    Console.WriteLine("You should expect to receive an D in the class");
                    Console.WriteLine("Please be aware that this is not a passing grade and you may need to retake the class");
                    Console.WriteLine();
                    Console.WriteLine("Please press any key to continue...");
                    Console.ReadKey(true);
                }
                else if ((grade >= 60) && (grade <= 61)) // 60-61 is a D-
                {
                    Console.WriteLine("You should expect to receive an D- in the class");
                    Console.WriteLine("Please be aware that this is not a passing grade and you may need to retake the class");
                    Console.WriteLine();
                    Console.WriteLine("Please press any key to continue...");
                    Console.ReadKey(true);
                }
                else if ((grade >=0) && (grade <= 59)) // 0-59 is an F
                {
                    Console.WriteLine("You should expect to receive an F in the class.");
                    Console.WriteLine("Consider withdrawing from the course or take it again at a later date.");
                    Console.WriteLine();
                    Console.WriteLine("Please press any key to continue...");
                    Console.ReadKey(true);
                }
                else // This statement will ensure that the user entered a value between 0 and 100
                {
                    Console.WriteLine("Please enter a value that is between 0 and 100.");
                    Console.WriteLine();
                    Console.WriteLine("Please press any key to continue...");
                    Console.ReadKey(true);
                }
            } // end of try section
            catch
            {
                // This catch block will ensure that the user has entered a number value
                Console.WriteLine("Please enter a number value between 0 and 100 for your grade next time...");
                Console.WriteLine();
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
            } // end of the catch block
        }
    }
}
