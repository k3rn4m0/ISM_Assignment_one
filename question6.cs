/* SELF REFLECTION: 
 * 
 * TIME TAKEN: 10 min
 * 
 * LEARNING:
 * Learnt about how to implement a gaming problem with different permutations. 
 * 
 * RECOMMENDATIONS:
 *N/A
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace ISM_Assignment_One
{
    class question6
    {
        public static void Main(string[] args)
        {
            // ASking user for input no. of stones
            Console.Write("n4 = ");

            // creating an integer variable to store the number of stones
            int n4 = Convert.ToInt32(Console.ReadLine());

            //Calling the method to see whether player 1 is the winner or not
            Stones(n4);
        }

        public static void Stones(int n4)
        {
            // Exception Handling

            try // try block
            {
                if (n4 % 4 == 0) // if condition to check whether the number of stones is a multiple of 4
                {
                    // if true Player 1 loses the game 
                    Console.Write("false");
                }
                else // if false Player 1 wins the game
                {
                    Console.WriteLine("true");


                }
            }
            catch // catch block 
            {
                Console.WriteLine("Exception Occured while computing Stones() method");
            }
        }



    }
}
