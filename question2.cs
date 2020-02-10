/* SELF REFLECTION: 
 * 
 * TIME TAKEN: 15 min
 * 
 * LEARNING:
 * This was a good extension to question 1 where we had to change the horizontal order to vertical one but with Sum of each element
 * 
 * RECOMMENDATIONS:
 * N/A
 * 
 */

using System;

namespace ISM_Assignment_one
{
    class question2
    {
        static void Main(string[] args)
        {
            // Taking the user inputa
            Console.Write("Enter the value of n: ");

            // Reading User input as a string and converting it into an integer
            int num = Convert.ToInt32(Console.ReadLine());

            // Calling the PrintSeries method to display the pattern
            PrintSeries(num);


        }

        private static void PrintSeries(int n2)
        {
            int Series_sum = 0; // Initializing the sum variable
            for (int i = 1; i <= n2; i++) // for loop to iterate and add till we reach the max input value
            {
                {
                    Series_sum = Series_sum + i; // Adding all the values from i till n2 to Sum
                    Console.Write(Series_sum); // Printing out the Sum
                    if (i < n2) // condition to check whether we've reached the last element
                    {
                        Console.Write(", "); // Output formatting as per the problem
                    }
                }
            }
            Console.WriteLine(); // printing a new line
        }
    }
}