/* SELF REFLECTION: 
 * 
 * TIME TAKEN: 36 min
 * 
 * LEARNING:
 * Took a step by step approach to output all 110 numbers first then attempted 11 per line & after that added conditions to 
 * replace multiples with U, S, F , US, SF & FU accordingly
 * 
 * RECOMMENDATIONS:
 * None
 * 
 */

using System;

namespace ISM_Assignment_One
{
    class question4
    {
        static void Main(string[] args)
        {
            // taking input form the user for the number till which the pattern ought to be printed
            Console.Write("n = ");
            int n3 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine();

            // input for numbers per line
            Console.Write("k = ");
            int k = Convert.ToInt32(Console.ReadLine());

            // calling the method 
            UsfNumbers(n3, k);
        }

        public static void UsfNumbers(int n3, int k)
        {
            //Exception Handling
            
            try // Try block
            {
                for (int i = 1; i <= n3; i++) // for loop to print the numbers
                {

                    if (i % 3 == 0 && i % 5 == 0) // checking for each number which are multiples of 3 & 5 and replacing them with "US"
                    {
                        Console.Write("US ");
                    }

                    else if (i % 5 == 0 && i % 7 == 0) // checking for multiples of 5 & 7 and replacing with SF
                    {
                        Console.Write("SF ");
                    }

                    else if (i % 7 == 0 && i % 3 == 0) // checking for multiples of 7 & 3 and replacing it with FU
                    {
                        Console.Write("FU ");
                    }

                    if (i % 3 == 0) // checking for multiples of 3 and replaing with U
                    {
                        Console.Write("U ");
                    }

                    else if (i % 5 == 0) // checking for multiples of 5 and replacing with S
                    {
                        Console.Write("S ");
                    }

                    else if (i % 7 == 0) // checking for multiples of 7 and replacing with F
                    {
                        Console.Write("F ");
                    }

                    else // if the number is not a multiple, printing the number itself
                    {
                        Console.Write(i + " ");
                    }

                    if (i % k == 0) // limiting the numbers per line
                    {
                        Console.WriteLine();
                    }

                }
            }
            catch  // Catch block
            {
                Console.WriteLine("Exception Occured in UsfNumbers() method");
            }

        }
    }
}
