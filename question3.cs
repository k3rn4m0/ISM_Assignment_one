/* SELF REFLECTION: 
 * 
 * TIME TAKEN: 
 * 
 * LEARNING:
 * 
 * 
 * RECOMMENDATIONS:
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace ISM_Assignment_One
{
    class question3
    {
        public static void Main(string[] args)
        {

            Console.Write("Input time in Earth Hours in the format(hh:mm:ssAM or hh:mm:ssPM): ");
            string s = Console.ReadLine();

            UsfTime(s);
        }

        public static string UsfTime(string s)
        {
            string ampm = s.Substring(8);
            if(ampm == "AM")
            {
                int hh = Convert.ToInt32(s.Substring(0, 2));
                int mm = Convert.ToInt32(s.Substring(3, 2));
                int ss = Convert.ToInt32(s.Substring(6, 2));



                s = hh + ":" + mm + ":" + ss;
                Console.Write("Output time in USF Planet in the format(UU:SS:FF): " + s);
                return s;
            }
            else
            {
                int hh = Convert.ToInt32(s.Substring(0, 2));
                int mm = Convert.ToInt32(s.Substring(3, 2));
                int ss = Convert.ToInt32(s.Substring(6, 2));

                hh += 13;
                mm += 1;
                ss += 1;

                s = hh + ":" + mm + ":" + ss;
                Console.Write("Output time in USF Planet in the format(UU:SS:FF): " + s);
                return s;
            }

           

            // s = s.Substring(s.Length - 2);
            // int v = Int32.Parse(s);

            // s = Convert.ToString(v);
            // return s;
        }
    }
}
