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
            Console.Write("n = ");
            int n3 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine();


            Console.Write("k = ");
            int k = Convert.ToInt32(Console.ReadLine());


            UsfNumbers(n3, k);
        }

        public static void UsfNumbers(int n3, int k)
        {
            //Exception Handling
            
            try // Try block
            {
                for (int i = 1; i <= n3; i++)
                {

                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.Write("US ");
                    }

                    else if (i % 5 == 0 && i % 7 == 0)
                    {
                        Console.Write("SF ");
                    }

                    else if (i % 7 == 0 && i % 3 == 0)
                    {
                        Console.Write("FU ");
                    }

                    if (i % 3 == 0)
                    {
                        Console.Write("U ");
                    }

                    else if (i % 5 == 0)
                    {
                        Console.Write("S ");
                    }

                    else if (i % 7 == 0)
                    {
                        Console.Write("F ");
                    }

                    else
                    {
                        Console.Write(i + " ");
                    }

                    if (i % k == 0)
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
