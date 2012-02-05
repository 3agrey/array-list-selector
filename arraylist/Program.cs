using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace arraylist
{
    class Selector
    {
        static void Main(string[] args)
        {
            ArrayList counter = new ArrayList();
            int remainder = 0;
            int a = 0;
            for (int ctr = 0; ctr < 100; ctr++)
            {
                counter.Add(ctr);
            }
            for (int ctr = 0; ctr < 100; ctr++)
            {
                a = Convert.ToInt32(counter[ctr]);
                Math.DivRem(a, 2, out remainder);
                if (remainder == 1)
                    counter[ctr] = "";
            }
            PrintValues(counter);
            Console.ReadKey();
        }

        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
                Console.Write(" {0}", obj);

            Console.WriteLine();
        }
    }
}

