using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList counter = new ArrayList();
            int remainder = 0;
            int a = 0;
            int i = 99;
            for (int ctr = 0; ctr <= i; ctr++)
            {
                counter.Add(ctr);
            }
            for (int ctr = i; ctr >= 0; ctr--)
            {
                a = Convert.ToInt32(counter[ctr]);
                Math.DivRem(a, 2, out remainder);
                if (remainder == 1)
                {
                    counter.RemoveAt(ctr);
                }
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
