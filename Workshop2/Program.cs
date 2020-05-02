using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop2
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int[] A = { 1, 2, 5, 10, 66, 69, 9, 10 };
            int max = ArrayMax(A);

            Console.ReadKey();

        }

        public int ArrayMax(int[] A)
        {
            int max = A[0];

            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                    Console.WriteLine(max + "\n" + i + 1);
                }
            }
            return max;
        }

    }
}
