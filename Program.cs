using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for input
            
            Console.WriteLine("Please enter the grade you expect to get in ISM 4300");
            
            /*
Use try catch block to validate user input. If the user provides bad input,
the catch block will handle the error and a message will be displayed.
*/
            try
            {
                //This variable will gather user input
                string input = Console.ReadLine();
               
                int grade = 0;

           
                /*
this if-else statement is used to conditionally test the user's input. Various options
are available depending on what is entered by the user.
*/
                if (grade >= 98)
                {
                    Console.WriteLine("Your letter grade is A+");
                    grade = int.Parse(Console.ReadLine());
                }
                else if (grade >= 92)
                {
                    Console.WriteLine("Your letter grade is A");
                    grade = int.Parse(Console.ReadLine());
                }
             else if (grade >= 90)
                {
                    Console.WriteLine("Your letter grade is A-");
                    grade = int.Parse(Console.ReadLine());
                }
               else if (grade >= 88)
                {
                    Console.WriteLine("Your letter grade is B+");
                    grade = int.Parse(Console.ReadLine());
                }
                else if (grade >= 82)
                {
                    Console.WriteLine("Your letter grade is B");
                    grade = int.Parse(Console.ReadLine());
                }
                else if (grade >= 80)
                {
                    Console.WriteLine("Your letter grade is B-");
                    grade = int.Parse(Console.ReadLine());
                }
                else if (grade >= 78)
                {
                    Console.WriteLine("Your letter grade is C+");
                    grade = int.Parse(Console.ReadLine());
                }
                else if (grade >= 72)
                {
                    Console.WriteLine("Your letter grade is C");
                    grade = int.Parse(Console.ReadLine());
                }
                else if (grade >= 70)
                {
                    Console.WriteLine("Your letter grade is C-");
                    grade = int.Parse(Console.ReadLine());
                }
                else if (grade >= 68)
                {
                    Console.WriteLine("Your letter grade is D+");
                    grade = int.Parse(Console.ReadLine());
                }
                else if (grade >= 62)
                {
                    Console.WriteLine("Your letter grade is D");
                    grade = int.Parse(Console.ReadLine());
                }
                else if (grade >= 60)
                {
                    Console.WriteLine("Your letter grade is D-");
                    grade = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Your letter grade is F");
                    grade = int.Parse(Console.ReadLine());
                }
            } //end of try
            catch
            {
                Console.WriteLine("Please enter a numeric value from 0-100");
                Console.WriteLine("Press any key to exit and try again.");
                Console.ReadKey(true);
            } //end of catch
        }
    }
}
