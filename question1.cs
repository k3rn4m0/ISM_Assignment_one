/* SELF REFLECTION: 
 * 
 * TIME TAKEN: 2 hrs
 * 
 * LEARNING:
 * Learnt how to use recursion after numerous trial and error attempts. Most ended in an infinite loop without providin required
 * conditions to decrement
 * 
 * RECOMMENDATIONS:
 * N/A
 * 
 */

using System;

namespace ISM_Assignment_one
{
    class question1
    {
        static void Main(string[] args)
        {
            // Taking the user inputa
            Console.Write("Enter the value of n: ");

            // Reading User input as a string and converting it into an integer
            int num = Convert.ToInt32(Console.ReadLine());

            // Calling the PrintPattern method to display the pattern

            // while loop to check whether the pattern stops when the input is greater than 0
            while(num>0) 
            {    
                        PrintPattern(num);  // Function call for printing the pattern
                        Console.WriteLine(); // New line to print subsequent lines
                        num--; // decrementing line count value of num for the required pattern
            }
 

        }

          // Recursive method to print pattern
          private static void PrintPattern(int n)
            {

            // Exception Handling
            try // try block
            {
                if (n > 0) // checking whether the inital number to be printed is greater than 0
                {
                    Console.Write(n + " "); // Output each value of n
                    PrintPattern(n - 1);  // recursion to print all the values in descending order in a line
                }
            }

            catch // catch block 
            {
                Console.WriteLine("Exception occured while computing PrintPattern() method");
            }
            }
        
    }
}